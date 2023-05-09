using System.IO;

namespace primzahlen_tester

{
    public class Program 
    {
        

        static void Main(string[] args)
        {

            //C:\Users\norso\source\repos\primzahlen_tester\primzahlen_tester
            //SEW2-Uebung-13-Files.csv
        StreamReader sr = new StreamReader("../../../SEW2-Uebung-13-Files.csv");


        string s = sr.ReadToEnd();
            sr.Close();
        Console.WriteLine(s);
            
        Prim m1 = new Prim();
            m1.mcprim(s);

            
        Iprim m2 = new Iprim();
            m2.WPrim(m1.sary.ToArray());

        }
    }
}