using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


namespace Factory.Models
{
  public class Machine
  {
    
    public int MachineId { get; set; }
    [Required(ErrorMessage = "Machine type can't be left empty")]
    public string MachineType { get; set; }
    public string LastServiced {get; set;}
    public string Age {get; set;}
    public string MachineDescription { get; set; }
    public List<EngineerMachine> JoinEntities {get;} 
  }
}