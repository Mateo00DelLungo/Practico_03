using DataDLL.Domain;
using DataDLL.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataDLL.Data.Utils
{
    public class Loader
    {
        public static List<Articulo> TableToListArticulo(DataTable dt)
        {
            if (dt == null || dt.Rows.Count == 0) { return null; }
            List<Articulo> lst = new List<Articulo>();
            foreach (DataRow row in dt.Rows)
            {
                lst.Add(LoadArticulo(row));
            }
            return lst;
        }
        public static Articulo LoadArticulo(DataRow row)
        {
            int id = Convert.ToInt32(row["id"]);
            string nombre = row["nombre"].ToString();
            double precio = Convert.ToDouble(row["precio_unitario"]);
            
            return new Articulo(id, nombre, precio);
        }
        public static List<Factura> TableToListFactura(DataTable dt)
        {
            if (dt == null || dt.Rows.Count == 0) { return null; }
            List<Factura> lst = new List<Factura>();
            foreach (DataRow row in dt.Rows)
            {
                lst.Add(LoadFactura(row));
            }
            return lst;
        }
        public static Factura LoadFactura(DataRow row)
        {
            int id = Convert.ToInt32(row["id"]);
            DateTime fecha = Convert.ToDateTime(row["fecha"].ToString());
            int pagoid = Convert.ToInt32(row["forma_pago_id"].ToString());
            int cliente = Convert.ToInt32(row["cliente_id"].ToString());
            int nrofactura = Convert.ToInt32(row["nro_factura"].ToString());
            return new Factura(id, fecha, pagoid, cliente, nrofactura);
        }
    }
}
