namespace exel_reader.Models{
  public class Payment{
    public string Name {get; set;} = string.Empty;
    public string PhoneNumber {get; set;} = string.Empty;
    public string PaymentMode {get; set;} = string.Empty;
    public decimal Amount {get; set;}
  }
}