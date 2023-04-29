using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teorieMostenire
{
    public class Avion:Vehicul
    {
        //proprietati
        private String modelAripi;
        private String modelTurbina;
        private String tipAvion;

       

        public Avion(string model,string marca,double pret,string modelAripi, string modelTurbina, string tipAvion)
            :base(1234)
        {

            Console.WriteLine("eu sunt constructorul cu toti paratrii din  derivata");
            this.modelAripi = modelAripi;
            this.modelTurbina = modelTurbina;
            this.tipAvion = tipAvion;

           
        }

        public String ModelAripi
        {
            get { return modelAripi; }
            set { modelAripi = value; }
        }

        public String ModelTurbina
        {
            get { return modelTurbina; }
            set { modelTurbina = value; }
        }

        public String TipAvion
        {
            get { return tipAvion; }
            set { tipAvion = value; }
        }

    }
}
