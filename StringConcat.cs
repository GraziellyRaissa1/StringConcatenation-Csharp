using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringConcatenation
{
    internal class StringConcat
    {
        public static void Main(string[] args)
        {
            string nome = "GRazielly";

            string sobrenome = "Raissa";

            string nomeInt = string.Concat(nome , sobrenome);

            Console.WriteLine(nomeInt);
        }
    }
}
