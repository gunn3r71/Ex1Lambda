using System;
using System.Collections.Generic;

namespace Ex1Lambda
{
    public class Program
    {

        static void Main(string[] args)
        {
            List<double> elements = new()
            {
                3,7,2,4,6
            };

            elements = elements.ConvertAll(x => x / 2);

            elements.ForEach(x => Console.WriteLine(x));
        }
    }
}
