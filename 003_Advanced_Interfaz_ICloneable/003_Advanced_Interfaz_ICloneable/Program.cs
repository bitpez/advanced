using System;

namespace _001_Advanced_Interfaz
{
    class Program
    {
        static void Main(string[] args)
        {
            // ejemplo con objetos no clonados
            CTelevisor miTelevisor = new CTelevisor();
            CTelevisor tuTelevisor = miTelevisor;

            // aqui pensamos que hicimos el clonado, vemos los dos objetos
            Console.WriteLine("Objetos sin ningun cambio\n");

            miTelevisor.MuestraInformacion();
            tuTelevisor.MuestraInformacion();

            // modificamos un objeto
            tuTelevisor.ColocarCosto(1300.80);

            // vemos los dos objetos nuevamente
            miTelevisor.MuestraInformacion();
            tuTelevisor.MuestraInformacion();

            // usamos las clases que implementan IClonable
            CRadio miRadio = new CRadio();

            // clonamos el objeto
            CRadio tuRadio = (CRadio)miRadio.Clone();

            // vemos los dos objetos
            Console.WriteLine("\n---Radios--");
            Console.WriteLine("\nObjetos sin cambio");
            miRadio.MuestraInformacion();
            tuRadio.MuestraInformacion();

            // modificamos un objeto
            tuRadio.ColocarCosto(800.50);

            // vemos los objetos
            miRadio.MuestraInformacion();
            tuRadio.MuestraInformacion();
        }
    }
}
