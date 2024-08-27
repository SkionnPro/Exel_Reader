using OfficeOpenXml;
using exel_reader.Models;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace exel_reader.Services{
  public class ExelService{
    public List<Payment> ReadPayments(Stream exelFile){

      var payments = new List<Payment>();

      using(var exelPackage = new ExcelPackage(exelFile)){

        var worksheet = exelPackage.Workbook.Worksheets[0];

        if(worksheet == null || worksheet.Dimension == null) return payments;

        var rows = worksheet.Dimension.Rows;

        for(int row = 2; row <= rows; row++){
          var payment = new Payment{
            Name = worksheet.Cells[row, 2].Text,
            PhoneNumber = worksheet.Cells[row,3].Text,
            PaymentMode = worksheet.Cells[row,4].Text,
            Amount = decimal.Parse(worksheet.Cells[row,5].Text)
          };
          
          payments.Add(payment);
        }
      }
      return payments;
    }

    public Dictionary<string, (decimal TotalAmount, List<Payment> Payments)> ArrangedList(List<Payment> payments){
      return payments
        .GroupBy(p => p.PaymentMode)
        .ToDictionary(
          g => g.Key,
          g => (
            TotalAmount: g.Sum(p => p.Amount),
            Payments: g.ToList()
          )
        );
    }
  }
}