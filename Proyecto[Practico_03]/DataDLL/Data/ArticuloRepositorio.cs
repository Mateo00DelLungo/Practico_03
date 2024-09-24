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
    public class ArticuloRepositorio : IArticuloRepository
    {
        private readonly DataHelper helper;
        public ArticuloRepositorio()
        {
            helper = DataHelper.GetInstance();
        }
        
        public bool Delete(int id)
        {
            bool result = false;
            List<Parametro> parametros = new List<Parametro>() { new Parametro("@id",id) };
            result = (1 == helper.ExecuteSPNonQuery("SP_DELETE_ARTICULOS", parametros));
            return result;
        }

        public List<Articulo> GetAll()
        {
            return Loader.TableToListArticulo(helper.ExecuteSPQuery("SP_GET_ALL_ARTICULOS",null));
        }

        public Articulo GetById(int id)
        {
            List<Parametro> parametros = new List<Parametro>() { new Parametro("@id",id) };
            var dt = helper.ExecuteSPQuery("SP_GET_BYID_ARTICULOS", parametros);
            if (dt == null || dt.Rows.Count == 0) { return null;}
            return Loader.LoadArticulo(dt.Rows[0]);
        }

        public bool Save(Articulo oArticulo)
        {
            List<Parametro> parametros = new List<Parametro>
            {
                new Parametro("@id", oArticulo.Id),
                new Parametro("@nombre", oArticulo.Nombre),
                new Parametro("@precio", oArticulo.PrecioUnitario)
            };
            int rows = helper.ExecuteSPNonQuery("SP_SAVE_ARTICULOS", parametros);
            return rows == 1;
        }
    }
}
