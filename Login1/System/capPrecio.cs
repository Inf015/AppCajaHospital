using Login1;

namespace System
{
    internal class capPrecio
    {
        private Action<object, EventArgs, Facturacion.capPrecio> btlGuardar_Click;

        public capPrecio(Action<object, EventArgs, Facturacion.capPrecio> btlGuardar_Click)
        {
            this.btlGuardar_Click = btlGuardar_Click;
        }
    }
}