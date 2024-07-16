using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace importarDatos.Models;

[Table("datoscsv")]
public class Datos
{
    public int codigo_loc { get; set; }
    public int consec_ctr { get; set; }
    public int codigo_trs { get; set; }
    public float id_emp { get; set; }
    public int valor_ctr { get; set; }
    public DateTime fecha_ctr { get; set; }
    public string estado_ctr { get; set; }
}
