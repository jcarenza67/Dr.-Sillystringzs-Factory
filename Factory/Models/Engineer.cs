using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


namespace Factory.Models
{
  public class Engineer
  {
    public int EngineerId {get; set;}
    [Required(ErrorMessage = "Engineer First name can't be left empty")]
    public string EngineerFName {get; set;}
    [Required(ErrorMessage = "Engineer Last name can't be left empty")]
    public string EngineerLName {get; set;}
    [Required(ErrorMessage = "Engineer License can't be left empty")]
    public string EngineerLicense {get; set;}
    [Required(ErrorMessage = "Engineer comments can't be left empty")]
    public string Comments {get; set;}
    public int MachineId { get; set; }
    public List<EngineerMachine> JoinEntities {get;}
  }
}
