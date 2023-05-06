using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teorieMostenire.models
{
    internal class Barca : Vehicul
    {

        private string tipBarca;
        private string tipMotorBarca;

        public Barca()
        {

        }

        public Barca(string tipBarca, string tipMotorBarca, string model, string marca, double pret) : base(pret, marca, model)
        {
            this.tipBarca = tipBarca;
            this.tipMotorBarca = tipMotorBarca;
        }

        public string TipBarca
        {
            get { return tipBarca; }
            set { tipBarca = value; }
        }

        public string TipMotorBarca
        {
            get { return TipMotorBarca; }
            set { tipMotorBarca = value; }
        }

        public string descriereBarca()
        {
            string text = "";

            text += "Modelul barcii este " + Model + "\n";
            text += "Marca barcii este " + Marca + "\n"; ;
            text += "Tipul de motor al barcii este " + tipMotorBarca + "\n";
            text += "Tipul barcii este " + tipBarca + "\n";
            text += "Pretul barcii este " + Pret + "\n";

            return text;
        }
    }
}
