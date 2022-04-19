using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Responsi2283
{
    class Karyawan
    {
        /* contructor */
        public Karyawan()
        {
          
        }
        /* overload sontructor */
        public Karyawan(string nama, string nik, int gajibulanan)
        {
            NAMA = nama;
            NIM = nik;
            GajiBulanan = gajibulanan;
        }
        /* properties */
        public string NAMA { get; set; }
        public string NIM { get; set; }
        public int GajiBulanan { get; set; }


    }
}