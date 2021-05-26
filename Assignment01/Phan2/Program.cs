using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phan2
{
    class Program
    {
         static void Main()
        {

            //Bai tap 1:
            //int radius = 4;
            //const double PI = 3.14159;
            //double circum, area;
            //area = PI * radius * radius;
            //circum = 2 * PI * radius;
            //// in kết quả
            //Console.WriteLine($"Ban kinh = {radius}, PI = {PI}"); 
            //Console.WriteLine($"Dien tich {area}");
            //Console.WriteLine($"Chu vi {circum}");


            // Bai tap 3:
            //int x, y;
            //for (x = 0; x < 10; x++, System.Console.Write("\n")) ;
            //for (y = 0; y < 10; y++, System.Console.WriteLine("{0}",y)) ;    

            //Bai tap 5:
            Console.WriteLine("Xin chao");
            Console.WriteLine("Tam biet");

            //Bai tap 6:
            Console.WriteLine("Xin chao"); //Console.WriteLine('Xin chao');
            Console.WriteLine("Tam biet"); //Consoile.WriteLine('Tam biet');

            //Bai tap 7:
            Console.OutputEncoding = Encoding.UTF8;
            //Console.BackgroundColor = ConsoleColor.Cyan;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\tRằm tháng giêng");
            Console.WriteLine(" Rằm xuân lồng lộng trăng soi,\n Sông xuân nước lẫn màu trời thêm\n xuân. Giữa dòng bàn bạc việc quân\n Khuya về bát ngát trăng ngân đầy thuyền.");
            Console.ReadKey();
        }
    }
}
