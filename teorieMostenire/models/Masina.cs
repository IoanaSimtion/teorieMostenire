using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teorieMostenire.models
{
    public class Masina : Vehicul
    {
        //propietati
        private string id;
        private string tipMotor;

        public Masina()
        {

        }


        public Masina(string id, string tipMotor, string marca, string model, double pret) : base(pret, marca, model)
        {
            this.id = id;
            this.tipMotor = tipMotor;
        }

        public string Id
        {
            get { return id; }
            set { id = value; }
        }

        public string TipMotor
        {
            get { return tipMotor; }
            set { tipMotor = value; }
        }

        public string descriereMasina()
        {
            string text = "";

            text += "Modelul masinii este " + Model + "\n";
            text += "Marca masinii este " + Marca + "\n";
            text += "ID-ul masinii este " + id + "\n";
            text += "Tipul motorului este " + tipMotor + "\n";
            text += "Pretul masinii este " + Pret + "\n";

            return text;
        }
    }
}
