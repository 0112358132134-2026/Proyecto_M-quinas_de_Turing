using System;
using System.Collections.Generic;
using System.Linq;

namespace Proyecto_Máquinas_de_Turing
{
    public class FunMet
    {
        public bool LlenarMT(string[] lineas, MT mt)
        {
            try
            {
                List<string> lineasAux = lineas.OfType<string>().ToList();

                mt.CantEstados = Int32.Parse(lineasAux[0]);
                lineasAux.RemoveAt(0);

                mt.S = Int32.Parse(lineasAux[0]);
                lineasAux.RemoveAt(0);

                //validar que no ingrese comas
                mt.Alfabeto = new List<char>();
                foreach (char item in lineasAux[0])
                {
                    if (item == ',')
                    {
                        lineasAux[-1] = "";
                    }
                    mt.Alfabeto.Add(item);
                }
                lineasAux.RemoveAt(0);

                List<Transicion> transiciones = new List<Transicion>();
                for (int i = 0; i < lineasAux.Count; i++)
                {
                    string[] transicion = lineasAux[i].Split(',');

                    char[] leidoAux = transicion[1].ToCharArray();
                    char[] escribirAux = transicion[3].ToCharArray();
                    char[] movAux = transicion[4].ToUpper().ToCharArray();

                    Transicion aux = new Transicion
                    {
                        S = Int32.Parse(transicion[0]),
                        Leido = leidoAux[0],
                        F = Int32.Parse(transicion[2]),
                        Escribir = escribirAux[0],
                        Mov = movAux[0]
                    };
                    transiciones.Add(aux);
                }
                mt.Transiciones = transiciones;
                return true;
            }
            catch (Exception)
            {
                return false;
            }          
        }
    }
}