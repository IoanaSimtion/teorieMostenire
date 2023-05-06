using System;
using teorieMostenire.models;
using teorieMostenire.services;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {

            VehiculService vh = new VehiculService();


            //vh.afisareDescriere();

            vh.contorizare();


        }
    }
}