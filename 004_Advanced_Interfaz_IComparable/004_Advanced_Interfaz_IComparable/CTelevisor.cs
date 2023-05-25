using System;

namespace _001_Advanced_Interfaz
{
    class CTelevisor : IProducto, IComparable
    {
        double costo;
        double impuesto;
        readonly string descripcion;

        public CTelevisor(string descipcion, double costo)
        {
            // inicializamos los datos
            this.costo = costo;
            this.descripcion = descipcion;
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
        /// metodo de la interfaz IComparable, este método lleva a cabo la 
        /// comparacion, recibe el objeto que vamos a comparar con la instancia ejecutada
        /// si el valor de retorno es 0 los objetos son iguales
        /// si el retorno es < 0 la instancia esta antes que el objeto a comparar
        /// si el valor de retornno es > 0 la instancia esta despues que el objeto a comparar
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public int CompareTo(object obj)
        {
            CTelevisor temp = (CTelevisor)obj;

            if (this.costo > temp.costo)
            {
                return 1;
            }

            if (this.costo < temp.costo)
            {
                return -1;
            }

            return 0;
        }
    }
}