using System;

namespace _001_Advanced_Interfaz
{
    class CTelevisor : IProducto
    {
        double costo;
        double impuesto;
        readonly string descripcion;

        public CTelevisor()
        {
            // inicializamos los datos
            this.costo = 400.0;
            this.descripcion = "Televisor pantalla plana";
        }

        public void ColocarCosto(double costo)
        {
            // asignamos el costo
            this.costo = costo;
        }

        public void CalcularImpuesto(double impuesto)
        {
            // calculamos el impuesto
            this.impuesto = costo * impuesto;
        }

        public void MuestraInformacion()
        {
            // mostramos la informacion necesaria
            Console.WriteLine("--Producto televisor");
            Console.WriteLine(descripcion);
            Console.WriteLine("Costo {0}, Impuesto {1}", costo, impuesto);
        }
    }
}