using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teorieMostenire
{
    public class Vehicul
    {
        //proprietati
        private double pret;
        private String marca;
        private String model;

        //constructori gol si unu de initialiare get si set
       

        public Vehicul(double pret, String marca, String model)
        {
            this.pret = pret;
            this.marca = marca;
            this.model = model;
        }

        public Vehicul(double pret)
        {
            Console.WriteLine("eu sunt constructorul cu un paramteru din baza");
            this.pret = pret;
            this.model = "undeifned";
            this.marca = "undefined";

        }



        public double Pret
        {
            get { return pret; }
            set {

                if (value < 0)
                {
                    Console.WriteLine("nu vreau");
                }
                else
                {
                    pret = value;
                }
                      
            
            }
        }

        public String Marca
        {
            get { return marca; }
            set { marca = value; }
        }

        public String Model
        {
            get { return model; }
            set { model= value; }
        }
       
    }
}
