using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashtableApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Hashtable aHashtable = new Hashtable();
            aHashtable.Add("111","ASP.NET MVC");
            aHashtable.Add("222","Java Basics ");
            aHashtable.Add("102","Laravel");
            aHashtable.Add("101","Zend");
            aHashtable.Add("987","SEO");
            string couresName = (string) aHashtable["111"];
            Console.WriteLine(couresName);
            Console.ReadLine();
        }
    }
}
