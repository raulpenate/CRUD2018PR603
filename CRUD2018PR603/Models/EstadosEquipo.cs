using System.ComponentModel.DataAnnotations;

namespace CRUD2018PR603.Models;

public class EstadosEquipo 
{
    [Key]
    public int id_equipos { get; set; }
    public string descripcion { get; set; }
    public  char estado { get; set; }
}