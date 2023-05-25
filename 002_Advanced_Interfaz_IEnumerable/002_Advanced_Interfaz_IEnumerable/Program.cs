namespace _001_Advanced_Interfaz
{
    class Program
    {
        static void Main(string[] args)
        {
            // instanciamos la tienda
            CTiendaTelevisor miTienda = new CTiendaTelevisor();

            foreach (CTelevisor item in miTienda)
            {
                // calculamos el impuesto
                item.CalcularImpuesto(0.16);

                // mostramos la informacion
                item.MuestraInformacion();
            }
        }
    }
}
