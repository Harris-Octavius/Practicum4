﻿using System;
using System.IO;

namespace Practicum4
{
    //Naam: Haico Wong, 6046983
    //In samenwerking met: Max Cozijn, 

    public class Program
    {
        /* 
         * Het hoofdprogramma leest een regel van de standaardinvoer, en zet die om naar een formule.
         * We zoeken een valuatie die de formule vervult.
         * Als dat lukt, printen we "SAT" op de eerste regel van de standaarduitvoer, en op de tweede regel de valuatie.
         * Als de formule niet vervulbaar is, printen we alleen "UNSAT" op de eerste regel.
         */
        public static void Main()
        {
            while (true)
            {
                try
                {
                    String invoer = Console.ReadLine();


                    IFormule formule = Parser.ParseFormule(invoer);
                    Console.WriteLine(formule.ToString());  // deze regel kun je gebruiken om de parser te testen

                    DateTime start = DateTime.Now;
                    Valuatie valuatie = Solver.Vervulbaar(formule);
                    DateTime eind = DateTime.Now;

                    invoer = Console.ReadLine();  
                    if (invoer == "p")
                    {
                        Console.WriteLine(formule.ToString()); 
                    }else if (invoer == "e")
                    {
                        
                    }else if (invoer == "t")
                    {
                        
                    }else if (invoer == "u")
                    {
                        
                    }else if (invoer == "v")
                    {
                        
                    }else if (invoer =="n")
                    {
                        if (valuatie == null)
                            Console.Write($"SAT\n{valuatie}");
                    }else if (invoer == "y")
                    {
                        if (valuatie == null)
                            Console.WriteLine("UNSAT");
                        else Console.WriteLine($"SAT\n{valuatie}");
                    }



                    Console.WriteLine($"oplostijd: {(eind - start).Ticks / 1E7} seconde");   // deze regel kun je gebruiken om het solve-proces te timen

                }
                catch (Exception exc)
                {
                    // De parser kan exceptions opwerpen als de formule syntaxfouten bevat
                    Console.WriteLine($"FOUT: {exc.Message}");
                }

                break;  // in de definitieve versie moet deze break staan, zodat er maar 1 formule wordt verwerkt.
                        // tijdens het testen kun je hem tijdelijk weghalen, zodat je meerdere formules na elkaar kunt proberen.
            }
            Console.ReadLine();   // in de definitieve versie moet dit weg, maar tijdens interactief testen voorkomt dit dat het window meteen wegflitst
        }
    }
}
