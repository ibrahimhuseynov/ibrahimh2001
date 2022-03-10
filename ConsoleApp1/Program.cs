using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main( string[] args)
        {
            Console.WriteLine(namesurname("azad a"));
            Console.ReadLine();
        }
        static string namesurname( string name )
        {
            char one = ' ' ;
            for (int i = 0; i <name.Length; i++)
            {
               if(name[i] == one)
                {
                  string newname = name-name[i];
                    return newname;
                }
            }
             
        }
    }
}
