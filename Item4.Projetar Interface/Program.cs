using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Topico2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Televisao televisao = new Televisao();
            //Abajur abajur = new Abajur();
            //Lanterna lanterna = new Lanterna();
            //Radio radio = new Radio();

            //abajur = new Televisao();
            //televisao = new Abajur();
            //radio = new Lanterna();
            //lanterna = new Radio();

            IEletrodomestico eletro1 = new Televisao();
            IEletrodomestico eletro2 = new Abajur();
            IEletrodomestico eletro3 = new Lanterna();
            IEletrodomestico eletro4 = new Radio();

            eletro2 = new Televisao();
            eletro1 = new Abajur();
            eletro4 = new Lanterna();
            eletro3 = new Radio();

            Console.ReadKey();
        }
    }

    class Televisao : IEletrodomestico, IRadioReceptor
    {
        public event EventHandler Ligou;
        public event EventHandler Desligou;

        //public double FrequenciaDoCanal { get; set; }
        public double Frequencia { get; set; }

        public void Desligar()
        {
        }

        public void Ligar()
        {
            if (Ligou != null)
            {
                Ligou(this, new EventArgs());
            }
        }
    }

    class Abajur : IEletrodomestico
    {
        public int PotenciaDaLampada { get; set; }

        public event EventHandler Ligou;
        public event EventHandler Desligou;

        public void Desligar()
        {
        }

        public void Ligar()
        {
        }
    }

    class Lanterna : IEletrodomestico
    {
        public double PotenciaDaLampada { get; set; }

        public event EventHandler Ligou;
        public event EventHandler Desligou;

        public void Desligar()
        {
        }

        public void Ligar()
        {
        }
    }

    class Radio : IEletrodomestico, IRadioReceptor
    {
        public event EventHandler Ligou;
        public event EventHandler Desligou;

        //public double FrequenciaDaEstacao { get; set; }
        public double Frequencia { get; set; }

        public void Desligar()
        {
        }

        public void Ligar()
        {
        }
    }

    //interface IEletrodomestico
    //{
    //    //métodos
    //    void Ligar();
    //    void Desligar();
    //}

    interface IEletrodomestico
    {
        //métodos
        void Ligar();
        void Desligar();

        //eventos
        event EventHandler Ligou;
        event EventHandler Desligou;
    }

    //interface IIluminacao
    //{
    //    //propriedades
    //    double PotenciaDaLampada { get; set; }
    //}

    interface IRadioReceptor
    {
        //propriedades
        double Frequencia { get; set; }
    }
}
