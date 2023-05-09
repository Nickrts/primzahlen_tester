using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace primzahlen_tester
{
    public class Prim
    {
        private string[] ary;

        public List<int> sary;

        List<string> fary;

      
        public void mcprim(string s)
        {

            string[] ary = s.Split(",");

            sary = new List<int>();

            fary = new List<string>();


            for (int i = 0; i < ary.Length; i++)
            {
                try
                {  
                    sary.Add(Convert.ToInt32(ary[i]));
                }
                catch
                {
                   
                    fary.Add(ary[i].ToString());
                }
            }
            foreach(int i in sary)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("es gibt " + fary.Count + " Fehler,diese werden mit null ersetzt");
            foreach(string a in fary)
            { 
                Console.WriteLine(a);
            }
            
        }
    }
}
