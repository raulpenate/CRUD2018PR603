using System.ComponentModel.DataAnnotations;

namespace CRUD2018PR603.Models;

public class TipoEquipo
{
    [Key]
    public int id_tipo_equipo { get; set; }
    public string descripcion { get; set; }
    public  char estado { get; set; }
}