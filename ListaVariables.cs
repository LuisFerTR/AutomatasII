using System;
using System.IO;
using System.Collections.Generic;

namespace sintaxis3
{
    public class ListaVariables
    {
        List<Variable> lista;

        public ListaVariables()
        {
            lista = new List<Variable>();
        }

        public void Inserta(string nombre, Variable.tipo tipoDato)
        {
            lista.Add(new Variable(nombre, tipoDato));
        } 

        public bool Existe(string nombre)
        {
            return lista.Exists(x => x.getNombre() == nombre);
        }

        public void setValor(string nombre, string valor)
        {
            foreach (Variable x in lista)
            {
                if (x.getNombre() == nombre)
                {
                    x.setValor(valor);
                    break;
                }
            }
        }

        public string getValor(string nombre)
        {
            foreach (Variable x in lista)
            {
                if (x.getNombre() == nombre)
                {
                    return x.getValor();                    
                }
            }

            return "";
        }

        public Variable.tipo getTipoDato(string nombre)
        {
            foreach (Variable x in lista)
            {
                if (x.getNombre() == nombre)
                {
                    return x.getTipoDato();                    
                }
            }

            return Variable.tipo.CHAR;
        }

        public void imprime(StreamWriter bitacora)
        {
            bitacora.WriteLine("Lista de variables:");

            foreach (Variable x in lista)
            {
                bitacora.WriteLine(x.getNombre() + " " + x.getValor() + " " + x.getTipoDato());
            }
        }
    }
}