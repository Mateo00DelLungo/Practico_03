namespace Proyecto_Practica_02_.Models
{
    public class ArticuloDTO
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public double PrecioUnitario { get; set; }

        public bool Validar()
        {
            bool result = false;
            if(this != null && this.Nombre != string.Empty && this.PrecioUnitario >= 0)
            {
                result = true;
            }
            return result;
        }
        public override string ToString()
        {
            return $"[{Id}] - {Nombre} - ${PrecioUnitario}";
        }
    }
}
