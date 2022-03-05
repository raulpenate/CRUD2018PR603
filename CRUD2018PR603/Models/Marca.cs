using System.ComponentModel.DataAnnotations;

namespace CRUD2018PR603.Models;

public class Marca
{
    [Key]
    public int id_marcas { get; set; }
    public string nombre_marca { get; set; }
    public  char estado { get; set; }
}