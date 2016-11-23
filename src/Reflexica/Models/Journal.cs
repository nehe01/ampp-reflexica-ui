namespace Reflexica.Models
{
  public class Journal
  {
    public OutputFormat OutputFormat { get; set; }
    public Styles Styles { get; set; }
    public Customers Customers { get; set; }
    public Languages Languages { get; set; }
  }

  public enum OutputFormat
  {
    Color,
    Texcolor,
    Xmltag,
    APlusPlus
  }

  public enum Styles
  {
    None,
    Basic,
    Mps,
    MathPhySci,
    Msp,
    Chemistry,
    Aps,
    Vancouver,
    Apa,
    Chicago,
    ApaOrg,
    ElsApas,
    ElsVancouver,
    Elsacs
  }

  public enum Customers
  {
    Springer,
    Elsevier,
    SpringerIncs,
    Springerbookmetrix
  }

  public enum Languages
  {
    English,
    German
  }
}