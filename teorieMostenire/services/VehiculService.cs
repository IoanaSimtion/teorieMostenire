using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using teorieMostenire.models;

namespace teorieMostenire.services
{
    public class VehiculService
    {

        private List<Vehicul> vehicule;

        public VehiculService()
        {
            vehicule = new List<Vehicul>();

            load();

        }

        public void load()
        {

            //avioane:

            Avion avion1 = new Avion("modeAvion1", "marcaAvion1", 14325, "aripi1", "turbina1", "avion1");
            Avion avion2 = new Avion("modeAvion2", "marcaAvion2", 453343, "aripi2", "turbina2", "avion2");
            Avion avion3 = new Avion("modeAvion3", "marcaAvion3", 676586, "aripi3", "turbina3", "avion3");


            //masini:

            Masina masina1 = new Masina("IDmasina1", "motorMasina1", "marcaMasina1", "modelMasina1", 214325);
            Masina masina2 = new Masina("IDmasina2", "motorMasina2", "marcaMasina2", "modelMasina2", 54322);
            Masina masina3 = new Masina("IDmasina3", "motorMasina3", "marcaMasina3", "modelMasina3", 363232);


            //barci:

            Barca barca1 = new Barca("barca1", "motorBarca1", "modelBarca1", "maracBarca1", 14546);
            Barca barca2 = new Barca("barca2", "motorBarca2", "modelBarca2", "maracBarca2", 4326234);
            Barca barca3 = new Barca("barca3", "motorBarca3", "modelBarca3", "maracBarca3", 8750346);

           
            vehicule.Add(avion1);
            vehicule.Add(avion2);
            vehicule.Add(avion3);
            vehicule.Add(masina1);
            vehicule.Add(masina2);
            vehicule.Add(masina3);
            vehicule.Add(barca1);
            vehicule.Add(barca2);
            vehicule.Add(barca3);
        }

        public void afisareDescriere()
        {

            foreach(Vehicul v in vehicule)
            {
                if(v is Masina)
                {
                    Masina m = v as Masina;
                    Console.WriteLine(m.descriereMasina());
                }
                if(v is Avion)
                {
                    Avion a = v as Avion;
                    Console.WriteLine(a.descriereAvion());
                }
                if(v is Barca)
                {
                    Barca b = v as Barca;
                    Console.WriteLine(b.descriereBarca());
                }
            }

        }

        public int[] contorizare()
        {
            int[] frecventa = new int[3] { 0, 0, 0 };
            int ctMasina = 0, ctAvion = 0, ctBarca = 0;

            foreach (Vehicul v in vehicule)
            {
                if (v is Masina)
                {
                    frecventa[0]++;
                }
                if (v is Avion)
                {
                    frecventa[1]++;
                }
                if (v is Barca)
                {
                    frecventa[2]++;
                }
            }

            return frecventa;

        }


      
    }
}
