using System;
using System.Runtime.Intrinsics.X86;
using System.Security.Cryptography.X509Certificates;

namespace ConsoleApp2
{
    class Program
    {


        static void Main(string[] args)
        {
            // Bài 1
            /*
            Console.WriteLine("Nhap ho va ten: ");
            string name = Console.ReadLine();

            Console.WriteLine("Nhap nam sinh: ");
            int NamSinh = System.Int32.Parse(Console.ReadLine());

            Console.WriteLine("Ho va ten: " +name);
            Console.WriteLine("Nam sinh: " +NamSinh);

             int TuoiHienTai = 2021 - NamSinh;
            Console.WriteLine("Tuoi hien tai: " + TuoiHienTai);

            int Tuoi2010 = 2000 + TuoiHienTai - 2010;
            Console.WriteLine("Tuoi vao nam 2010 la: " + Tuoi2010);
            */

            //Bài 2
            /*
            Console.WriteLine("Nhap x = ");
            int x = int.Parse(Console.ReadLine());

            int Expression = 3*x*x + 4*x - 7;
            Console.WriteLine("Gia tri cua bieu thuc la: "+Expression);
            */

            //Bài 3
            /*
            Console.WriteLine("Nhap x = ");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap y = ");
            int y = int.Parse(Console.ReadLine());
            int Expression = 4 * x * 2 * y + 6 * x * y * 2 - 13;
            Console.WriteLine( "khi x = " + x +  ",khi y = " + y +". Gia tri cua Expression la :" +Expression );
            //Bài 4
            Console.WriteLine("Nhap ho ten :");
            String HoTen = Console.ReadLine();
            Console.WriteLine("Nhap chi so dien ke thang truoc");
            float ChiSoCu = float.Parse(Console.ReadLine());
            Console.WriteLine("Nhap chi dien ke thang nay: ");
            float ChiSoMoi = float.Parse(Console.ReadLine());

            float TieuThu = ChiSoMoi - ChiSoCu;
            float TienDien = TieuThu * (float)452.45;
            //

            Console.WriteLine("Khach hang:" + "<" + HoTen + ">");
            Console.WriteLine("Chi so cu: " + "<" + ChiSoCu + ">");
            Console.WriteLine("Chi so moi: " + "<" + ChiSoMoi + ">");
            Console.WriteLine("Tieu thu: " + TieuThu);
            Console.WriteLine("Tien dien la :" + TienDien);
            
            //Bài 5 
            Console.WriteLine("Nhap ho ten : ");
            String Hoten = Console.ReadLine();
            Console.WriteLine("Nhap chi so dien ke thang truoc: ");
            float chiSoCu = float.Parse(Console.ReadLine());
            Console.WriteLine("Nhap chi so dien ke thang nay: ");
            float chiSoMoi = float.Parse(Console.ReadLine());
            float TieuThu = chiSoMoi - chiSoCu;
            int TienThueDienKe = 12426;
            float TienDien = TieuThu * (float)452.45+TienThueDienKe;
            float TienPhu =TienDien * (float)0.1;
            
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("=========Hoa Don Tien Dien=========");

            Console.WriteLine("Khach hang: " + "<" + Hoten + ">");
            Console.WriteLine("Chi so cu: " + "<" + chiSoCu + ">");
            Console.WriteLine("Chi so moi: " + "<" + chiSoMoi + ">");
            Console.WriteLine("Tieu thu: " + "<" +TieuThu+ ">");
            Console.WriteLine("Tien dien: " + "<" + TienDien + ">");
            Console.WriteLine("Tien phu :" + "<" + TienPhu + ">");
               
            Console.WriteLine("----------------------------------------");
            */
            // Bài 7
            Console.WriteLine("=============Tim x=====================");

            Console.WriteLine("Nhap a = ");
            float a = float.Parse(Console.ReadLine());
            Console.WriteLine("Nhap b =");
            float b = float.Parse(Console.ReadLine());
             float x = -b / a;
            float BieuThuc = a * x + b;
            Console.WriteLine("Phuong trinh: " + a + "x"+ "+" + b + "= 0 ");
            Console.WriteLine("x = " + x);
            Console.WriteLine("----------------------------------------");
        }

    }
}
