using DataDLL.Domain;
using Microsoft.OpenApi.Validations;
using Proyecto_Practica_02_.Models;
using Proyecto_Practico_03_.Models;
using System.Net.NetworkInformation;

namespace Proyecto_Practica_02_.Services
{
    public static class Mapper
    {
        public static Articulo SetArticulo(ArticuloDTO dto)
        {
            var oArticulo = new Articulo()
            {
                Id = dto.Id,
                Nombre = dto.Nombre,
                PrecioUnitario = dto.PrecioUnitario
            };
            return oArticulo;
        }
        public static ArticuloDTO GetArticulo(Articulo oArticulo)
        {
            if(oArticulo == null){ return null;}
            var dto = new ArticuloDTO()
            {
                Id = oArticulo.Id,
                Nombre = oArticulo.Nombre,
                PrecioUnitario = oArticulo.PrecioUnitario
            };
            return dto;
        }
        public static List<ArticuloDTO> GetListArticulo(List<Articulo> articulos)
        {
            if(articulos == null || articulos.Count == 0) { return null; }
            List<ArticuloDTO> lstdto = new List<ArticuloDTO>();
            foreach (Articulo articulo in articulos)
            {
                lstdto.Add(GetArticulo(articulo));
            }
            return lstdto;
        }
        public static Factura SetFactura(FacturaDTO dto)
        {
            var oFactura = new Factura()
            {
                Id = dto.Id,
                Fecha = dto.Fecha,
                FormaPagoId = dto.FormaPago,
                ClienteId = dto.Cliente,
                NumeroFactura = dto.NumeroFactura
            };
            return oFactura;
        }
        public static FacturaDTO GetFactura(Factura oFactura)
        {
            if(oFactura == null) { return null; }
            var dto = new FacturaDTO()
            {
                Id = oFactura.Id,
                Fecha = oFactura.Fecha,
                FormaPago = oFactura.FormaPagoId,
                Cliente = oFactura.ClienteId,
                NumeroFactura = oFactura.NumeroFactura,
            };
            return dto;
        }
        public static List<FacturaDTO> GetListFactura(List<Factura> facturas)
        {
            if(facturas == null || facturas.Count == 0) { return null; }
            List<FacturaDTO> lstdto = new List<FacturaDTO>();
            foreach(Factura factura in facturas)
            {
                lstdto.Add(GetFactura(factura));
            }
            return lstdto;
        }
    }
}
