using System;

namespace UsoCoches
{
    class Program
    {
        static void Main(string[] args)
        {
            Coche coche1 = new Coche();
            Coche coche2 = new Coche();
            Coche coche3 = new Coche(4500.35, 1200.35);

            Console.WriteLine(coche1.getInfoCoche());
            Console.WriteLine(coche3.getInfoCoche());

            coche3.setExtras(true, "cuero"); 
            Console.WriteLine(coche3.getExtras());
        }
    }

    class Coche
    {

        public Coche()
        {
            ruedas = 4;
            largo = 2300.5;
            ancho = 0.800;
        }

        public Coche(double largocoche, double anchocoche)
        {
            ruedas = 4;
            largo = largocoche;
            ancho = anchocoche;
        }

        public String getInfoCoche()
        {
            return "Informacion del coche: \n "+"Ruedas: "+ ruedas+ "\n Largo : " + largo+ "\n Ancho : " + ancho;
        }

        public void setExtras(bool paramClimatizador, String paramTapiceria)
        {

            climatizador = paramClimatizador;
            tapiceria = paramTapiceria;
        }

        public string getExtras()
        {
            return "Extras del coche; \n" + "Tapiceria : " + tapiceria + "\n Climatizador " + climatizador;
        }

        private int ruedas;

        private double largo;

        private double ancho;

        private bool climatizador;

        private String tapiceria;
    }
}
