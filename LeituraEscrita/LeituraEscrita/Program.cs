using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeituraEscrita
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> listaNumeros = new List<int>();

            Leitura(listaNumeros);
            listaNumeros.Sort();
            Escrita(listaNumeros);
        }

        static void Leitura(List<int> listaNumeros) {
            String line;
            try
            {
                //Pass the file path and file name to the StreamReader constructor
                StreamReader sr = new StreamReader("H:\\teste.txt");
                //Read the first line of text
                line = sr.ReadLine();
                //Continue to read until you reach end of file
                while (line != null)
                {
                    int numero = int.Parse(line);
                    listaNumeros.Add(numero);
                    //Read the next line
                    line = sr.ReadLine();
                }
                //close the file
                sr.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
            finally
            {
                Console.WriteLine("Executing finally block.");
            }
        }

        static void Escrita(List<int> listaNumeros) {
            try
            {
                //Pass the filepath and filename to the StreamWriter Constructor
                StreamWriter sw = new StreamWriter("H:\\teste.txt");

                foreach (int num in listaNumeros) {
                    sw.WriteLine(num);
                }
                //Close the file
                sw.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
            finally
            {
                Console.WriteLine("Executing finally block.");
            }
        }
    }
}
