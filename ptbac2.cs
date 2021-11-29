using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baitap
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;
            double x,y, Delta;
            Console.WriteLine("PTrinh: ax2 + bx + c = 0");
            Console.WriteLine("Delta: ∆ = b2 – 4ac");
            Console.WriteLine("--------------------");
            //input a,b,c
            Console.Write("Nhap so dau tien: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap so dau hai: ");
            b = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap so dau ba: ");
            c = Convert.ToInt32(Console.ReadLine());
            Delta = b * b - (4 * a * c);

            if (Delta > 0)
            {
                Console.Write("Phuong trinh co hai nghiem thuc phan biet.\n");

                x = (-b + Math.Sqrt(Delta)) / (2 * a);
                y = (-b - Math.Sqrt(Delta)) / (2 * a);

                Console.Write("Nghiem thu nhat: ", x);
                Console.Write("Nghiem thu hai: ", y);
            }
            else if (Delta == 0)
            {
                Console.Write("Phuong trinh co nghiem kep.\n");
                x = y = -b/2*a;
                Console.WriteLine("Phuong trinh co nghiem kep x1=x2=  ",x);
            }
            else {
                Console.Write("Phuong trinh vo nghiem.");
            }
        }
    }
}
