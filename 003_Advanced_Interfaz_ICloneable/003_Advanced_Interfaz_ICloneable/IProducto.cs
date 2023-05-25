namespace _001_Advanced_Interfaz
{
    interface IProducto
    {
        /// <summary>
        /// expone el comportamiento del producto
        /// </summary>
        /// <param name="impuesto"></param>
        void CalcularImpuesto(double impuesto);

        /// <summary>
        /// Mostrar informacion
        /// </summary>
        void MuestraInformacion();
    }
}