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
           int n1;
           int n2;
           int n3;
           Console.Write("Nhap so dau tien: ");
           n1 = Convert.ToInt32(Console.ReadLine());
           Console.Write("Nhap so dau hai: ");
           n2 = Convert.ToInt32(Console.ReadLine());
           Console.Write("Nhap so dau ba: ");
           n3 = Convert.ToInt32(Console.ReadLine());
         if (n1 > n2) {
             if (n1 > n3){
                 Console.WriteLine("so dau tien la so lon nhat");
             }
         }
         else if (n2 > n3){
             if (n2 > n2){
                 Console.WriteLine("So thu hai la so lon nhat");
             }
         }
         else if (n3 > n2){
             if (n3>n1){
                 Console.WriteLine("So thu 3 la so lon nhat");
             }
         }

        }
    }
}
