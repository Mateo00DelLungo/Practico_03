using Proyecto_Practica_02_.Models;

namespace Proyecto_Practico_03_.App
{
    public interface IArticuloCRUD
    {
        List<ArticuloDTO> GetAllArticulo();
        ArticuloDTO GetByIdArticulo(int id);
        bool SaveArticulo(ArticuloDTO oArticulo);
        bool DeleteArticulo(int id);
        bool UpdateArticulo(int id, ArticuloDTO oArticulo);
    }
}
