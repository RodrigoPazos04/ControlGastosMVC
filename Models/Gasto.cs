using System.ComponentModel.DataAnnotations;

namespace ControlGastos.Models
{
    public class Gasto
    {
        public int Id { get; set; }
        public string Descripcion { get; set; } = "";
        public decimal Monto { get; set; }
        public string Categoria { get; set; } = "";
        public DateTime Fecha { get; set; } = DateTime.Now;
    }
}
