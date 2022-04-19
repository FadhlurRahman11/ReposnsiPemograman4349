using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Responsi2283
{
    class Program
    {
        static void Main(string[] args)
        {
            // membuat objek Karyawan 1
            Karyawan karyawan1 = new Karyawan();

            // pengesetan properties
            karyawan1.NIM = "01.21.11.4349";
            karyawan1.NAMA = "Nur";
            karyawan1.GajiBulanan = 3000000;

            // Validasi karyawan 1
            if (karyawan1.GajiBulanan < 0)
            {
                karyawan1.GajiBulanan = 0;
            }

            // membuat objek Karyawan 2
            Karyawan karyawan2 = new Karyawan();

            // pengesetan properties
            karyawan2.NIM = "02.21.11.4349";
            karyawan2.NAMA = "Fadhlur";
            karyawan2.GajiBulanan = 2000000;

            // Validasi karyawan 2
            if (karyawan2.GajiBulanan < 0)
            {
                karyawan2.GajiBulanan = 0;
            }

            // membuat objek Karyawan 3
            Karyawan karyawan3 = new Karyawan();

            // pengesetan properties
            karyawan3.NIM = "03.21.11.4349";
            karyawan3.NAMA = "Rahman";
            karyawan3.GajiBulanan = 1500000;

            // Validasi karyawan 3
            if(karyawan3.GajiBulanan < 0)
            {
                karyawan3.GajiBulanan = 0;
            }

            //pemanggilan method
            Console.WriteLine("No. \tNik\t\tNama\t\tGaji Bulanan");
            Console.WriteLine("-----------------------------------------------------");
            Console.WriteLine("1. \t{0}\t{1}\t\t{2}", karyawan1.NIM, karyawan1.NAMA, karyawan1.GajiBulanan);
            Console.WriteLine("2. \t{0}\t{1}\t\t{2}", karyawan2.NIM, karyawan2.NAMA, karyawan2.GajiBulanan);
            Console.WriteLine("3. \t{0}\t{1}\t\t{2}", karyawan3.NIM, karyawan3.NAMA, karyawan3.GajiBulanan);

            Console.WriteLine("\n Aaasyiiiikk kita kenaikan Gaji 10%!!\n");

            Console.WriteLine("No. \tNik\t\tNama\t\tGaji Bulanan");
            Console.WriteLine("-----------------------------------------------------");

            Console.WriteLine("1. \t{0}\t{1}\t\t{2}", karyawan1.NIM, karyawan1.NAMA, karyawan1.GajiBulanan + (karyawan1.GajiBulanan * 0.10));
            Console.WriteLine("2. \t{0}\t{1}\t\t{2}", karyawan2.NIM, karyawan2.NAMA, karyawan2.GajiBulanan + (karyawan2.GajiBulanan * 0.10));
            Console.WriteLine("3. \t{0}\t{1}\t\t{2}", karyawan3.NIM, karyawan3.NAMA, karyawan3.GajiBulanan + (karyawan3.GajiBulanan * 0.10));

            Console.ReadKey();
        }
    }
}
