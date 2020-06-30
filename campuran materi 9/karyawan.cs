using System;
using System.Collections.Generic;
using System.Text;

namespace campuran_materi_9
{
    public abstract class Karyawan
    {
        public string name { get; set; }
        public string NIK { get; set; }
        public string JK { get; set; }
        public abstract double Gaji();
    }
}