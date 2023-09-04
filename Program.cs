using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Bai4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int intA, intB;
            double ketqua;
            Console.WriteLine(" ------------ CHUONG TRINH GIAI PHUONG TRINH BAC 1 ------------ ");
            Console.WriteLine(" ------------------------- aX + b = 0 ------------------------- ");
            Console.Write("Nhap a: ");
            intA = Convert.ToInt32(Console.ReadLine());
            Console.Write("{0}", "Nhap b: ");
            intB = Convert.ToInt32(Console.ReadLine());
            if (intA == 0 && intB == 0)
            {
                Console.WriteLine(" Phuong trinh co vo so nghiem");
            }
            else if (intA == 0 && intB != 0)
            {
                Console.WriteLine(" Phuong trinh vo nghiem");
            }
            else
            {
                ketqua = (double)-intB / intA;
                Console.WriteLine(" Phuong trinh co 1 nghiem duy nhat x = {0}", ketqua);
            }
            Console.ReadKey();


        }
    }
}
