using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Liste
{
    class Program
    {
        static void Main(string[] args)
        {
            Node<int> nekiBroj = new Node<int>();
            nekiBroj.Value = 12;
            Console.WriteLine(nekiBroj);

            Node<string> nekiString = new Node<string>();
            nekiString.Value = "neke reci";
            Console.WriteLine(nekiString);

            List<int> lista = new List<int>();
            Console.WriteLine(lista);

            lista.Add(55);
            lista.Add(99);
            Console.WriteLine(lista);
        }
    }
}
