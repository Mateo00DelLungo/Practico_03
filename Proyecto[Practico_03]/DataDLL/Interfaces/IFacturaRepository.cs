using DataDLL.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataDLL.Interfaces
{
    public interface IFacturaRepository
    {
        List<Factura> GetAll();
        Factura GetById(int id);
        bool Save(Factura oFactura);
        bool Update(Factura oFactura);
        bool Delete(int id);
    }
}
