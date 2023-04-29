using System;
using teorieMostenire;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Vehicul vehicul = new Vehicul();

            // vehicul.Pret = 220;
            // vehicul.Model = "MAKD";
            // vehicul.Marca = "adaa";

            // /*Console.WriteLine(vehicul.Pret);
            // Console.WriteLine(vehicul.Marca);
            // Console.WriteLine(vehicul.Model);*/

            // Avion avion = new Avion();

            // avion.Pret = 235211;
            // avion.Model = "svaav";
            // avion.Marca = "AVNVVS";
            // avion.ModelTurbina = "xxx";
            // avion.ModelAripi = "abc";
            // avion.TipAvion = "zva";

            //Avion avion2=new Avion("svabav", "basVVS", 567211, "df", "yyy", "maoer");

            //Console.WriteLine(avion.Pret);
            //Console.WriteLine(avion2.Pret);
            //Console.WriteLine(avion.ModelAripi);
            //Console.WriteLine(avion2.ModelAripi);
            //Console.WriteLine(avion.Marca);
            //Console.WriteLine(avion2.Marca);
            //Console.WriteLine(avion.TipAvion);
            //Console.WriteLine(avion2.TipAvion);
            //Console.WriteLine(avion.Model);
            //Console.WriteLine(avion2.Model);
            //Console.WriteLine(avion.ModelTurbina);
            //Console.WriteLine(avion2.ModelTurbina);

            Avion avion = new Avion("MCOADM", "nvs", 1444, "abc", "xxx", "navn");
            Console.WriteLine(avion.Pret);
            Console.WriteLine(avion.ModelAripi);
            Console.WriteLine(avion.Marca);
            Console.WriteLine(avion.TipAvion);
            Console.WriteLine(avion.Model);
            Console.WriteLine(avion.ModelTurbina);

        }
    }
}