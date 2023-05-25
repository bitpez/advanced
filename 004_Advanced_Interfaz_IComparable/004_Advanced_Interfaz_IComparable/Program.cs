using System;

namespace _001_Advanced_Interfaz
{
    class Program
    {
        static void Main(string[] args)
        {
            CTelevisor[] misTV = new CTelevisor[3];

            misTV[0] = new CTelevisor("Televisor de Plasma", 1500.50);
            misTV[1] = new CTelevisor("Televisor LCD", 2300.45);
            misTV[2] = new CTelevisor("Televisor de pantalla plana", 575.85);

            Console.WriteLine("-- Antes de ordenar --\n");
            for (int n = 0; n < misTV.Length; n++)
            {
                misTV[n].MuestraInformacion();
            }

            // ordenamos el arreglo aprovechando la implementacion de IComparable
            Array.Sort(misTV);

            Console.WriteLine("-- Despues de ordenar --\n");
            for (int n = 0; n < misTV.Length; n++)
            {
                misTV[n].MuestraInformacion();
            }
        }
    }
}
