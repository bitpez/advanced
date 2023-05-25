using System;

namespace _001_Advanced_Interfaz
{
    class CRadio : IProducto, ICloneable
    {
        double costo;
        double impuesto;
        string descripcion;

        public CRadio()
        {
            // inicializamos los datos
            this.costo = 150.85;
            this.descripcion = "Radio de onda corta";
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

        /// <summary>
        /// implementacion de IClonabe
        /// </summary>
        /// <returns></returns>
        public object Clone()
        {
            CRadio temp = new CRadio
            {
                costo = costo,
                descripcion = descripcion,
                impuesto = impuesto
            };

            return temp;
        }
    }
}
