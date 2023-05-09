using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace primzahlen_tester
{
    public class Prim
    {
     public void mcprim(string s)
        {
            String[] Separator = { "," };
            string[] ary = s.Split(",");
            string[] sary = new string[ary.Length];


            for(int i = 0; i < ary.Length; i++)
            {
                try
                {
                    sary[i] = ary[i];
                }
                catch
                {

                }
            }

        }
    }
}
