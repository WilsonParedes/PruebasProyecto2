using System;
using System.Collections.Generic;
using System.Text;

namespace Proyecto1
{
    class NodoVersiones<T>
    {
        private NodoRamas<T> v;

        public T dato { get; set; }
        public NodoVersiones<T> siguiente { get; set; }



        public NodoVersiones(T dato)
        {
            this.dato = dato;
            this.siguiente = null;
        }

        public NodoVersiones()
        {
            this.dato = default;
            this.siguiente = null;
        }

        public NodoVersiones(NodoRamas<T> v)
        {
            this.v = v;
        }

        public static explicit operator NodoVersiones<T>(NodoRamas<T> v)
        {
            return new NodoVersiones<T>(v);
            throw new NotImplementedException();
        }
    }
}
