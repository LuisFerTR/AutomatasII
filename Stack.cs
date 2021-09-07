using System;
using System.IO;

namespace sintaxis3
{
    public class Stack
    {
        int maxElementos;
        int ultimo;
        float[] elementos;

        public Stack(int maxElementos)
        {
            this.maxElementos = maxElementos;
            ultimo = 0;
            elementos = new float[maxElementos];
        }

        public void push(float element, StreamWriter bitacora)
        {
            if (ultimo < maxElementos)
            {
                bitacora.WriteLine("Push = " + element);
                elementos[ultimo++] = element; 
            }
            // else levantar excepción de stack overflow
        }

        public float pop(StreamWriter bitacora)
        {
            if (ultimo > 0)
            {
                bitacora.WriteLine("Pop = " + elementos[ultimo-1]);
                return elementos[--ultimo];
            }
            // else levantar excepción de stack underflow

            return 0;
        }

        public void display(StreamWriter bitacora)
        {
            bitacora.WriteLine("Contenido del stack: ");
            
            for (int i = 0; i < ultimo; i++)
            {
                bitacora.Write(elementos[i] + " ");
            }

            bitacora.WriteLine("");
        }
    }
}