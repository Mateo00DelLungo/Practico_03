using DataDLL.Data;
using DataDLL.Domain;
using DataDLL.Interfaces;
using Proyecto_Practica_02_.Models;
using Proyecto_Practica_02_.Services;
using Proyecto_Practico_03_.Models;

namespace Proyecto_Practico_03_.App
{
    public class Aplicacion : IFacturaCRUD, IArticuloCRUD
    {
        private readonly IArticuloRepository articuloRepo;
        private readonly IFacturaRepository facturaRepo;
        public Aplicacion()
        {
            articuloRepo = new ArticuloRepositorio();
            facturaRepo = new FacturaRepositorio();
        }
        public bool DeleteFactura(int id)
        {
            var deleted = facturaRepo.GetById(id);
            if(deleted == null) { return false; }
            return facturaRepo.Delete(id);
        }

        public List<FacturaDTO> GetAllFactura()
        {
            var lstFacturas = facturaRepo.GetAll();
            return Mapper.GetListFactura(lstFacturas);
        }

        public FacturaDTO GetByIdFactura(int id)
        {
            var facturadto = facturaRepo.GetById(id);
            return Mapper.GetFactura(facturadto);
        }

        public bool SaveFactura(FacturaDTO dto)
        {
            Factura oFactura = Mapper.SetFactura(dto);
            return facturaRepo.Save(oFactura);
        }

        public bool UpdateFactura(int id, FacturaDTO dto)
        {
            Factura oFactura = Mapper.SetFactura(dto);
            oFactura.Id = id;
            return facturaRepo.Update(oFactura);
        }
        //////////////////////    Articulo       /////////////////////        
        public bool SaveArticulo(ArticuloDTO dto)
        {
            Articulo oArticulo = Mapper.SetArticulo(dto);
            return articuloRepo.Save(oArticulo);
        }

        public bool DeleteArticulo(int id)
        {
            var deleted = articuloRepo.GetById(id);
            if (deleted == null) { return false; }
            return articuloRepo.Delete(id);
        }
        public List<ArticuloDTO> GetAllArticulo()
        {
            var lstarticulos = articuloRepo.GetAll();
            return Mapper.GetListArticulo(lstarticulos);
        }

        public ArticuloDTO GetByIdArticulo(int id)
        {
            Articulo articulo = articuloRepo.GetById(id);
            return Mapper.GetArticulo(articulo);
        }

        public bool UpdateArticulo(int id, ArticuloDTO dto)
        {
            var articulo = Mapper.SetArticulo(dto);
            articulo.Id = id;
            return articuloRepo.Save(articulo);
        }
    }
}

