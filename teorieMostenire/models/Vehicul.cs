using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teorieMostenire.models
{
    public class Vehicul
    {
        //proprietati
        private double pret;
        private string marca;
        private string model;

        //constructori gol si unu de initialiare get si set


        public Vehicul(double pret, string marca, string model)
        {
            this.pret = pret;
            this.marca = marca;
            this.model = model;
        }

        public Vehicul(double pret)
        {
            //Console.WriteLine("eu sunt constructorul cu un parametru din baza");
            this.pret = pret;
            model = "undeifned";
            marca = "undefined";

        }

        public Vehicul()
        {

        }

        public double Pret
        {
            get { return pret; }
            set
            {

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

        public string Marca
        {
            get { return marca; }
            set { marca = value; }
        }

        public string Model
        {
            get { return model; }
            set { model = value; }
        }


        public string descriereVehicul()
        {
            string text = "";

            text += "Marca vehicului este " + marca + "\n";
            text += "Modelul vehicului este " + model + "\n";
            text += "Pretul vehicului este " + pret + "\n";

            return text;
        }

    }
}
