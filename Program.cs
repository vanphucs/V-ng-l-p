using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VongLap
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;

            #region Bài 1
            //int n, sum, i;
            //Console.WriteLine("Tính tổng dãy số từ 1 đến n với n là số nguyên dương nhập vào từ bàn phím");
            //do
            //{
            //    Console.Write("\nNhập n: ");
            //    n = int.Parse(Console.ReadLine());
            //    if (n > 0)
            //    {
            //        sum = 0;
            //        for(i = 1; i <= n; i++)
            //        {
            //            sum = sum + i;
            //        }
            //        Console.Write("Tổng của các số từ 1 đến " + n + " là: " + sum);
            //    }
            //    else
            //    {
            //        Console.WriteLine("Nhập n là số nguyên dương");
            //        Console.Write("Vui lòng nhập lại: ");
            //    }
            //} while (n < 0);
            //Console.ReadKey();
            #endregion

            #region Bài 2
            //int sum = 0;
            //int n = 1;

            //while (sum <= 10000)
            //{
            //    sum += n;
            //    n++;
            //}
            //Console.WriteLine("Giá trị n nhỏ nhất là: " + n);
            //Console.ReadKey();
            #endregion

            #region Bài 3
            //int n, i;
            //Console.WriteLine("Bài toán in ra màn hình dãy số lẻ bé hơn một số n nguyên dương được nhập vào từ bàn phím");
            //do
            //{
            //    Console.Write("\nNhập n: ");
            //    n = int.Parse(Console.ReadLine());
            //    Console.WriteLine("Dãy số lẻ nhỏ hơn " + n + " là:");
            //    if (n > 0)
            //    {
            //        for (i = 1; i < n; i += 2)
            //        {
            //            Console.WriteLine(i) ;
            //        }
            //    }
            //    else
            //    {
            //        Console.WriteLine("Nhập n là số nguyên dương");
            //        Console.Write("Vui lòng nhập lại: ");
            //    }
            //}while (n < 0);
            //Console.ReadKey();

            #endregion

            #region Bài 4
            //int tongChan = 100;
            //int sum = 36;

            //int chanGa = 2;
            //int chanCho = 4;

            //int x, y; // x là số con gà, y là số con chó

            //for (x = 0; x <= sum; x++)
            //{
            //    y = sum - x;

            //    if ((chanGa * x + chanCho * y) == tongChan)
            //    {
            //        Console.WriteLine("Số con gà là: " + x);
            //        Console.WriteLine("Số con chó là: " + y);
            //        break;
            //    }
            //}
            //Console.ReadKey();
            #endregion

            #region Bài 5
            //int a, b;
            //Console.WriteLine("Chương trình tìm ước chung lớn nhất của m và n \n");

            //bool tieptucchuongtrinh = true;
            //while (tieptucchuongtrinh)
            //{
            //    do
            //    {
            //        Console.Write("Nhập m: ");
            //        a = int.Parse(Console.ReadLine());
            //        if (a < 0)
            //        {
            //            Console.WriteLine("Nhập sai!");
            //        }
            //    } while (a < 0);
            //    Console.WriteLine();
            //    do
            //    {
            //        Console.Write("Nhập n: ");
            //        b = int.Parse(Console.ReadLine());
            //        if (b < 0)
            //        {
            //            Console.WriteLine("Nhập sai!");
            //        }
            //    } while (b < 0);

            //    while (a * b != 0)
            //    {
            //        if (a > b)
            //        {
            //            a = a % b;
            //        }
            //        else if (a == b)
            //        {
            //            break;
            //        }
            //        else if (a < b)
            //        {                   
            //            b = b % a;
            //        }
            //    }
            //    Console.WriteLine("Ước chung lớn nhất (UCLN):" + b);
            //}
            //Console.ReadKey();
            #endregion
        }
    }
}
