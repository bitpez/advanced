namespace _001_Advanced_Interfaz
{
    class Program
    {
        static void Main(string[] args)
        {
            // la interfaz no puede instanciarse directamente
            // IProducto miProducto = new IProducto();

            // invocamos a una clase que implementa una interfaz
            CTelevisor miTelevisor = new CTelevisor();
            miTelevisor.CalcularImpuesto(0.16);
            miTelevisor.MuestraInformacion();

            // invocamos metodos propios de la clase
            miTelevisor.ColocarCosto(567.82);
            miTelevisor.CalcularImpuesto(0.16);
            miTelevisor.MuestraInformacion();
        }
    }
}
