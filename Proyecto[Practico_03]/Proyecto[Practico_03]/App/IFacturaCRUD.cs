using Proyecto_Practica_02_.Models;
using Proyecto_Practico_03_.Models;

namespace Proyecto_Practico_03_.App
{
    public interface IFacturaCRUD
    {
        List<FacturaDTO> GetAllFactura();
        FacturaDTO GetByIdFactura(int id);
        bool SaveFactura(FacturaDTO oArticulo);
        bool DeleteFactura(int id);
        bool UpdateFactura(int id, FacturaDTO oArticulo);
    }
}
