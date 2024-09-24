using DataDLL.Data.Utils;
using DataDLL.Domain;
using DataDLL.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataDLL.Data
{
    public class FacturaRepositorio : IFacturaRepository
    {
        private readonly DataHelper helper;
        public FacturaRepositorio()
        {
            helper = DataHelper.GetInstance();
        }
        
        public bool Delete(int id)
        {
            var parametros = new List<Parametro>() { new Parametro("@facturaid", id) };
            int rows = helper.ExecuteSPNonQuery("SP_DELETE_FACTURAS", parametros);
            return rows == 1;
        }

        public List<Factura> GetAll()
        {
            return Loader.TableToListFactura(helper.ExecuteSPQuery("SP_GET_MASTER", null));
        }

        public Factura GetById(int id)
        {
            var parametros = new List<Parametro>() { new Parametro("@id", id) };
            var dt = helper.ExecuteSPQuery("SP_GET_BYID_MASTER", parametros);
            if (dt == null || dt.Rows.Count == 0) { return null; }
            return Loader.LoadFactura(dt.Rows[0]);
        }

        public bool Save(Factura oFactura)
        {
            var parametros = new List<Parametro>()
            {
                new Parametro("@fecha", oFactura.Fecha),
                new Parametro("@formapagoid", oFactura.FormaPagoId),
                new Parametro("@clienteid", oFactura.ClienteId),
                new Parametro("@nrofactura", oFactura.NumeroFactura),
            };
            int rows = helper.ExecuteSPNonQuery("SP_SAVE_FACTURAS", parametros);
            return rows == 1;
        }
        public bool Update(Factura oFactura)
        {//necesita el id de la factura a modificar
            var parametros = new List<Parametro>()
            {
                new Parametro("@facturaid", oFactura.Id),
                new Parametro("@fecha", oFactura.Fecha),
                new Parametro("@formapagoid", oFactura.FormaPagoId),
                new Parametro("@clienteid", oFactura.ClienteId),
                new Parametro("@nrofactura", oFactura.NumeroFactura)
            };
            int rows = helper.ExecuteSPNonQuery("SP_UPDATE_FACTURAS", parametros);
            return rows == 1;
        }
    }
}
