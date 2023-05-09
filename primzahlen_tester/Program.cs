using System.IO;
namespace primzahlen_tester

{
    public class Program
    {
        static void Main(string[] args)
        {

            //C:\Users\norso\source\repos\primzahlen_tester\primzahlen_tester
            //SEW2-Uebung-13-Files.csv
        StreamReader sr = new StreamReader("SEW2-Uebung-13-Files.csv");


        string s = sr.ReadToEnd();
        Console.WriteLine(s);
            
        




        }
    }
}