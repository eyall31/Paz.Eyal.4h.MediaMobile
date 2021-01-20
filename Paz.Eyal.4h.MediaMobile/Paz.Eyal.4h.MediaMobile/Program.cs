using System;

namespace Paz.Eyal._4h.MediaMobile
{
    class Program
    {
        static void Main(string[] args)
        {

            Campione[] c = new Campione[10]; // vettore

            for (int i = 0; i < 10; i++)
            {

            }
        }
    }
  
    public class Campione
    {
        //variabili

        private string _data;
        private int _umidita; // si misura in percentuale
        private double _temperatura; // si misura in gradi
        private int _pressione; //si misura in millibar

        // property
        public string Data
        {
            get
            {
                return _data;
            }
            set
            {
                _data = value;
            }

        }
        public int Umidita
        {
            get
            {
                return _umidita;
            }
            set
            {
                _umidita = value;
            }

        }
        public double Temperatura
        {
            get
            {
                return _temperatura;
            }
            set
            {
                _temperatura=value;
            }

        }
        public int Presssione
        {
            get
            {
                return _pressione;
            }
            set
            {
                _pressione=value;
            }

        }
    }
}

