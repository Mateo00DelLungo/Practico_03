using Microsoft.AspNetCore.Components;

namespace Proyecto_Practico_03_.Models
{
    public class FacturaDTO
    {
        public int Id { get; set; }
        public DateTime Fecha { get; set; }
        public int FormaPago { get; set; }
        public int Cliente { get; set; }
        public int NumeroFactura { get; set; }
        public bool Validar()
        {
            bool result;
            if (this == null || Fecha == DateTime.MinValue|| FormaPago <= 0 || Cliente <= 0 || NumeroFactura <= 0)
            {
                return result = false;
            }
            return result = true;
        }
    }
}
