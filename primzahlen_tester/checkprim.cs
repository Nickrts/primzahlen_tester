using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace primzahlen_tester
{
    public class Iprim 
    {

      
        public bool IsPrim(int number)
        {
            if (number < 2)
                return false;
            //Keine Primzahl ist kleiner als 2

            if (number == 2)
                return true;
            //2 ist die einzige gerade Primzahl

            if ((number & 1) == 0)
                return false; //Keine gerade Zahl ungleich 2 ist eine Primzahl

            int limit = (int)Math.Ceiling(Math.Sqrt(number)); //Die Quadratwurzel des Kanidaten auf die nächsthöhere ganze Zahl gerundet

            for (int divisior = 3; divisior < limit; ++divisior)
            { //Durch 0 zu teilen wäre Schwachsinn, auch 2 als möglicher Teiler ist raus, fangen wir also mit der 3 an
                if (number % divisior == 0) 
                    return false; //Wenn hierbei 0 rauskommt, dann gibt es (mindestens) einen dritten Teiler, also keine Primzahl
            }
            return true; //Zusammengesetzte Zahlen sind ausgeschlossen, also Primzahl


        }
         

       
        public static List<int> dary = new List<int>();
         public void AddPrim(int[] l)
        {
            
         
            foreach(int i in l)
            {
                
                if (IsPrim (i)) 
                {
                    dary.Add(i);
                   
                    
                }


            }


        }
    }
}