using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataDLL.Domain
{
    public class Factura
    {
        public int Id { get; set; }
        public DateTime Fecha { get; set; }
        public int FormaPagoId { get; set; }
        public int ClienteId { get; set; }
        public int NumeroFactura { get; set; }
        public Factura(){}
        public Factura(int id, DateTime fecha, int pagoid, int cliente, int nrofactura)
        {
            Id = id;
            Fecha = fecha;
            FormaPagoId = pagoid;
            ClienteId = cliente;
            NumeroFactura = nrofactura;
        }
    }
}
