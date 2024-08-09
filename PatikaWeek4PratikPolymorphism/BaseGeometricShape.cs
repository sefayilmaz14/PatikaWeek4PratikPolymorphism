using System;
using System.Collections.Generic;
using System.Formats.Asn1;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace PatikaWeek4PratikPolymorphism
{
    public class BaseGeometricShape // Ortak sınfımızı oluşturduk
    {
        //Propetry tanımlamaları
        public int Height { get; set; }
        public int Width { get; set; }

        //Alan hesaplama methodu türetilen sınıflardada kullanılacağı için virtual olarak işlendi
        public virtual int AreaCalculation()
        {
            return Height * Width;

        }


    }

    //Kare alan hesaplama methodu ,override işlemi ve konsol bilgi mesajı
    public class Square : BaseGeometricShape
    {


        public override int AreaCalculation()
        {

            int area = base.AreaCalculation();
            Console.WriteLine($"Karenin Alanı:{area}");
            return area;

        }

    }
    //Dikdörtgen alan hesaplama methodu ,override işlemi ve konsol bilgi mesajı
    public class Rectangle : BaseGeometricShape
    {
        public override int AreaCalculation()
        {

            int area = base.AreaCalculation();
            Console.WriteLine($"Dikdörtgenin Alanı:{area}");
            return area;

        }
    }
    //Dikçgen alan hesaplama methodu ,override işlemi ve konsol bilgi mesajı
    public class Triangle : BaseGeometricShape
    {
        public override int AreaCalculation()
        {

            int area = base.AreaCalculation() / 2;
            Console.WriteLine($"Diküçgenin Alanı:{area}");
            return area;

        }
    }
}
