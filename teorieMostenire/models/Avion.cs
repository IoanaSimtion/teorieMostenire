using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teorieMostenire.models
{
    public class Avion : Vehicul
    {
        //proprietati
        private string modelAripi;
        private string modelTurbina;
        private string tipAvion;

        public Avion(string model, string marca, double pret, string modelAripi, string modelTurbina, string tipAvion)
            : base(pret, marca, model)
        {
            //Console.WriteLine("eu sunt constructorul cu toti parametrii din derivata");
            this.modelAripi = modelAripi;
            this.modelTurbina = modelTurbina;
            this.tipAvion = tipAvion;
        }

        public string ModelAripi
        {
            get { return modelAripi; }
            set { modelAripi = value; }
        }

        public string ModelTurbina
        {
            get { return modelTurbina; }
            set { modelTurbina = value; }
        }

        public string TipAvion
        {
            get { return tipAvion; }
            set { tipAvion = value; }
        }

        public string descriereAvion()
        {
            string text = "";

            text += "Modelul avionului este " + Model + "\n";
            text += "Marca avionului este " + Marca + "\n";
            text += "Modelul aripilor este " + modelAripi + "\n";
            text += "Tipul avionului este " + tipAvion + "\n";
            text += "Pretul avionului este " + Pret + "\n";

            return text;
        }

    }
}
