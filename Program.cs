using System;

namespace Tugas_6
{
    class program
    {
        static void Main(string[] args)
        {
            // Object
            Mahasiswa mhs = new Mahasiswa();
            // Implementasi Object
            mhs.nama = "MUH.REZKY SYAPUTRA";
            mhs.nim = "22.11.4816";
            mhs.Kampus = "Universitas Amikom Yogyakarta";
            mhs.Ipk = 3.5;

            mhs.dataMahasiswa();
            mhs.cekKelulusan();

            Console.ReadLine();

        }
    }
}

