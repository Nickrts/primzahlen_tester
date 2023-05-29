using System.IO;

namespace primzahlen_tester

{
    public class Program 
    {
        static void Main(string[] args)
        {

            //C:\Users\norso\source\repos\primzahlen_tester\primzahlen_tester
            //SEW2-Uebung-13-Files.csv



           
            if (args[0] == "-i")
            {
                StreamReader sr;
                sr = new StreamReader(args[1]);
                string s = sr.ReadToEnd();
                sr.Close();
                Console.WriteLine(s);
                
                Prim m1 = new Prim();
                m1.mcprim(s);

             
                Iprim m2 = new Iprim();
                m2.AddPrim(m1.safelist.ToArray());
            }

          
            if (args[2] == "-t")
            {  
                StreamWriter sw;
                sw = new StreamWriter(args[3]);
                sw.WriteLine(String.Join(",", Iprim.dary));
                sw.Close();

            }
            
            if (args[4] == "-o")
            {  
                StreamWriter sw;
                sw = new StreamWriter(args[3]);
                sw.WriteLine(String.Join(",", Iprim.dary));
                sw.Close();

            }
        }
    }
}