using Microsoft.AspNetCore.Mvc;
using exel_reader.Models;
using exel_reader.Services;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

namespace exel_reader.Controllers{
  public class ExelController : Controller{
    private readonly ExelService _exelService;

    public ExelController(ExelService exelService){
      _exelService = exelService;
    }

    public IActionResult Index(){
      return View();
    }

    public async Task<IActionResult> Upload(IFormFile file){
      if(file == null || file.Length == 0){
        return BadRequest("No file Selected");
      }

      try{
        using(var stream = new MemoryStream()){
          await file.CopyToAsync(stream);
          stream.Position = 0;
          var payments = _exelService.ReadPayments(stream);

          if(payments.Count == 0){
            return View("Results", new Dictionary<string, (decimal TotalAmount, List<Payment> Payments)>());
          }

          var total = _exelService.ArrangedList(payments);

          return View("Results",total);
        }
      }
      catch(Exception){
        return StatusCode(500, "Internal Server Error");
      }
    }
  }
}