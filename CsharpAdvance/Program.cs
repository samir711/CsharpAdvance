using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpAdvance
{
    class Program
    {
        static void Main(string[] args)
        {

            var number = new Nullable<int>();

            Console.WriteLine("Has Value ? " + number.HasValue);
            Console.WriteLine(" Value is : " + number.GetValueOrDefault());

            //var number = new GenericList<int>();
            //number.Add(10);

            //var books = new GenericList<Book>();
            //books.Add(new Book());

            //var dictionary = new GenericDictionary<string, Book>();
            //dictionary.Add("1234", new Book());




        }
    }
}
