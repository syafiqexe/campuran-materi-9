using System;
using System.Collections.Generic;
using System.Text;

namespace campuran_materi_9
{
    public class KaryawanTetap : Karyawan
    {
        public double GajiBulanan { get; set; }
        public override double Gaji()
        {
            return GajiBulanan;
        }
    }
}