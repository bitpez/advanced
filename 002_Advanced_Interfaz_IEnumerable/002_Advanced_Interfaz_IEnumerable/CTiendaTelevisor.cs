using System.Collections;

namespace _001_Advanced_Interfaz
{
    class CTiendaTelevisor : IEnumerable
    {
        private CTelevisor[] _televisores;

        public CTiendaTelevisor()
        {
            // arreglo que va a contener 3 televisores
            _televisores = new CTelevisor[3];
            _televisores[0] = new CTelevisor("Televisor LCD", 1500.0);
            _televisores[1] = new CTelevisor("Televisor Plasma", 1800.50);
            _televisores[2] = new CTelevisor("Televisor LED", 2500.75);
        }

        // implementamos IEnumerable
        public IEnumerator GetEnumerator()
        {
            return _televisores.GetEnumerator();
        }
    }
}
