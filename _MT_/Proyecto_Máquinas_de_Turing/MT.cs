using System.Collections.Generic;

namespace Proyecto_Máquinas_de_Turing
{
    public class MT
    {
        public int CantEstados;
        public int S;
        public List<char> Alfabeto;
        public List<Transicion> Transiciones;
        public List<char> Palabra;

        public Transicion Buscar_Transicion(int estadoActual, char simbolo)
        {
            Transicion transicion = new Transicion
            {
                Encontrada = false
            };

            for (int i = 0; i < Transiciones.Count; i++)
            {
                if ((Transiciones[i].S == estadoActual) && (Transiciones[i].Leido == simbolo))
                {
                    transicion.S = Transiciones[i].S;
                    transicion.Leido = Transiciones[i].Leido;
                    transicion.F = Transiciones[i].F;
                    transicion.Escribir = Transiciones[i].Escribir;
                    transicion.Mov = Transiciones[i].Mov;
                    transicion.Encontrada = true;
                    break;
                }
            }
            return transicion;
        }

        public void Agregar_Palabra(string palabra)
        {
            Palabra = new List<char>
            {
                '_'
            };

            foreach (char item in palabra)
            {
                Palabra.Add(item);
            }
            Palabra.Add('_');
        }

        public bool Validar_Palabra(string palabra)
        {
            List<string> alfabetoEntrada = new List<string>();
            for (int i = 0; i < Transiciones.Count; i++)
            {
                if (Transiciones[i].Leido != '_')
                {
                    if (!alfabetoEntrada.Contains(Transiciones[i].Leido.ToString()))
                    {
                        alfabetoEntrada.Add(Transiciones[i].Leido.ToString());
                    }                    
                }                
            }

            bool valido = true;
            for (int i = 0; i < palabra.Length; i++)
            {
                if (!alfabetoEntrada.Contains(palabra[i].ToString()))
                {
                    valido = false;
                    break;
                }              
            }

            return valido;
        }
    }
}