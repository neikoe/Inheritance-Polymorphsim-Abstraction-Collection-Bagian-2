using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hitung_Gaji_Karyawan.Classinduk
{
    public abstract class Karyawan
    {
        public abstract string nik {get;set;}
			public abstract string nama {get;set;}
				public abstract double gaji();
    }
}
