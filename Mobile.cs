using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rabota
{
    internal class Mobile
    {
        //свойства
        private string _model; //модель телефона
        public string Model
        {
            get { return _model; }
            set { _model = value; }
        }
        private string _colour; //цвет телефона
        public string Colour
        {
            get { return _colour; }
            set { _colour = value; }
        }
        private DateTime _datapok; //дата покупки телефона
        public DateTime Datapok
        {
            get { return _datapok; }
            set { _datapok = value; }
        }
        private int _price; //цена телефона
        public int Price
        {
            get { return _price; }
            set { _price = value; }
        }
        private int _guarantee; //гарантия
        public int Guarantee
        {
            get { return _guarantee; }
            set { _guarantee = value; }
        }

        //методы
        public void PrintInfo()
        {
            Console.WriteLine($"{Model}, {Colour}, {Datapok}, {Price}, {Guarantee}");
        }

        public void PriceCheck()
        {
            if (Price > 30000)
            {
                Console.WriteLine("Такое не потянем");
            }
            else
            {
                Console.WriteLine("Такое потянем");
            }
        }

        public void GuaranteeCheck()
        {
            int year = Datapok.Year;
            int c_year = DateTime.Now.Year;
            if (c_year - year > Guarantee)
            {
                Console.WriteLine("Гарантия истекла");
            }
            else
            {
                Console.WriteLine("Гарантия не истекла");
            }
        }
    }
}
