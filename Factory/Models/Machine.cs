using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


namespace Factory.Models
{
  public class Machine
  {
    
    public int MachineId { get; set; }
    [Required(ErrorMessage = "Machine type can't be left empty")]
    public string MachineType { get; set; }
    [Required(ErrorMessage = "Machine service can't be left empty")]
    public string LastServiced {get; set;}
    [Required(ErrorMessage = "Machine age can't be left empty")]
    public string Age {get; set;}
    [Required(ErrorMessage = "Machine description can't be left empty")]
    public string MachineDescription { get; set; }
    public List<EngineerMachine> JoinEntities {get;} 
  }
}