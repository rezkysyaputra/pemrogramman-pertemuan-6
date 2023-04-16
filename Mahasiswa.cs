using System;

namespace Tugas_6
{
    // Class
    internal class Mahasiswa
    {
        // field
        public string nama;
        public string nim;
        private string _kampus;
        private double _ipk;
        protected double ipkMin = 2.0;
        protected double ipkMax = 4.0;

        public string Kampus
        {
            get
            {
                return _kampus;
            }
            set
            {
                this._kampus = value;
            }
        }
        public double Ipk
        {
            get
            {
                return _ipk;
            }
            set
            {
                _ipk = value;
            }
        }

        // Method
        public void dataMahasiswa()
        {
            Console.WriteLine("<<-----Data Mahasiswa----->>");
            Console.WriteLine("> Nama: {0}", nama);
            Console.WriteLine("> Nim: {0}", nim);
            Console.WriteLine("> Kampus: {0}", Kampus);
            Console.WriteLine("> IPK: {0}", Ipk);
            Console.WriteLine("----------------------------");
        }

        public void cekKelulusan()
        {
            if (ipkMax >= Ipk && ipkMin <= Ipk)
            {
                Console.WriteLine("Selamat {0} Anda dinyatakan LULUS dengan nilai IPK {1}, Ditingkatkan lagi biar jadi presiden🤩🎉", nama, Ipk);
            }
            else if (ipkMin > Ipk)
            {
                Console.WriteLine("Mohon maaf {0} Anda dinyatakan TIDAK LULUS dengan nilai IPK {1}, belajar lebih giat lagi ya🤓📚", nama, Ipk);
            }
            else
            {
                Console.WriteLine("Mohon maaf {0} Ada kesalahan penginputan nilai IPK kamu yaitu {1}, mohon melakukan pengecekan🧐🔍\n", nama, Ipk);
            }
        }

    }
}