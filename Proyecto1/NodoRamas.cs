using System;
using System.Collections.Generic;
using System.Text;

namespace Proyecto1
{
    class NodoRamas<T>
    {
        private NodoVersiones<T> Version;

        public T datoRamas { get; set; }
        public NodoRamas<T> siguiente { get; set; }
        public NodoRamas<T> enlace { get; set; }



        public NodoRamas(T datoRamas)
        {
            this.datoRamas = datoRamas;
            this.siguiente = null;
            this.enlace = null;
        }
        public NodoRamas()
        {
            this.datoRamas = default;
            this.siguiente = null;
            this.enlace = null;
        }

        public NodoRamas(NodoVersiones<T> Version)
        {
            this.Version = Version;
        }

        public static explicit operator NodoRamas<T>(NodoVersiones<T> Version)
        {
            return new NodoRamas<T>(Version);
            throw new NotImplementedException();
        }
    }
}
