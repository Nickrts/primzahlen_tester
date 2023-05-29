using System.IO;

namespace primzahlen_tester

{
    public class Program 
    {
        static void Main(string[] args)
        {

            //C:\Users\norso\source\repos\primzahlen_tester\primzahlen_tester
            //SEW2-Uebung-13-Files.csv



            for (int i = 0; i < args.Length; i+=2)
            {
                if (args[i] == "-i")
                {
                    StreamReader sr;
                    sr = new StreamReader(args[i+1]);
                    string s = sr.ReadToEnd();
                    sr.Close();
                    Console.WriteLine(s);
                
                    Prim m1 = new Prim();
                    m1.mcprim(s);

             
                    Iprim m2 = new Iprim();
                    m2.AddPrim(m1.safelist.ToArray());
                }

          
                if (args[i] == "-t")
                {  
                    StreamReader sr;
                    sr = new StreamReader(args[i+1]);
                    string s = sr.ReadToEnd();
                    sr.Close();
                    Console.WriteLine(s);
                
                    Prim m1 = new Prim();
                    m1.mcprim(s);

             
                    Iprim m2 = new Iprim();
                    m2.AddPrim(m1.safelist.ToArray());
                }
            
                if (args[i] == "-o")
                {  
                    StreamWriter sw;
                    sw = new StreamWriter(args[i+1]);
                    sw.WriteLine(String.Join(",", Iprim.primlist));
                    sw.Close();

                }

               
            }  
        
        }
    }
}