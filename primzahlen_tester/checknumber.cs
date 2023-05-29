using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace primzahlen_tester
{
    public class Prim
    {
        private string[] unsortedary;

        public List<int> safelist;

        List<string> failedlist;

      
        public void mcprim(string s)
        {

            string[] ary = s.Split(",");

            safelist = new List<int>();

            failedlist = new List<string>();


            for (int i = 0; i < ary.Length; i++)
            {
                try
                {  
                    safelist.Add(Convert.ToInt32(unsortedary[i]));
                }
                catch
                {
                   
                //    failedlist.Add(unsortedary[i].ToString()); 
                }
            }
           
            Console.WriteLine("es gibt " + failedlist.Count + " Fehler");
            foreach(string a in failedlist)
            { 
                Console.WriteLine(a);
            }
            
        }
    }
}
