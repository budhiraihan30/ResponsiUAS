using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectMahasiswa
{
    class Program
    {
        // deklarasi objek collection untuk menampung objek mahasiswa
        static List<Mahasiswa> daftar_mahasiswa = new List<Mahasiswa>();

        static void Main(string[] args)
        {
            Console.Title = "Responsi UAS Matakuliah Pemrograman";
            bool statusMenu = true;


            while (statusMenu)
            {
                TampilMenu();

                Console.Write("\nNomor Menu [1..3]: ");
                int nomorMenu = Convert.ToInt32(Console.ReadLine());

                switch (nomorMenu)
                {
                    case 1:
                        TambahMahasiswa();
                        break;

                    case 2:
                        HapusMahasiswa();
                        break;

                    case 3:
                        TampilMahasiswa();
                        break;

                    case 4: // keluar dari program
                        statusMenu = false;
                        return;

                    default:
                        break;
                }
            }
        }

        static void TampilMenu()
        {
            Console.Clear();
            Console.WriteLine("Ketikkan angka yang ingin di pilih :");
            Console.WriteLine();
            Console.WriteLine("1. Tambah Mahasiswa");
            Console.WriteLine("2. Hapus Mahasiswa");
            Console.WriteLine("3. Tampilkan Mahasiswa");
            Console.WriteLine("4. Keluar");
            Console.WriteLine();
        }

        static void TambahMahasiswa()
        {
            Console.Clear();
            Console.WriteLine("Tambah Data Mahasiswa");
            // PERINTAH: lengkapi kode untuk menambahkan objek mahasiswa ke dalam collection
            Console.Write("NPM : ");
            string nim = Console.ReadLine();
            Console.Write("NAMA :");
            string nama = Console.ReadLine();
            Console.Write("Jenis Kelamin [L/P] :");
            char gender = Convert.ToChar(Console.ReadLine());
            string jenisKelamin;
            if (gender == 'L')
            {
                jenisKelamin = "Laki-Laki";
            }
            else
            {
                jenisKelamin = "Perempuan";
            }

            Console.Write("IPK :");
            string ipk = Console.ReadLine();



            Mahasiswa mahasiswa = new Mahasiswa();
            mahasiswa.npm = nim;
            mahasiswa.nama_mahasiswa = nama;
            mahasiswa.jenis_kelamin = jenisKelamin;
            mahasiswa.IPK = ipk;

            daftar_mahasiswa.Add(mahasiswa);


            Console.WriteLine("\nTekan ENTER untuk kembali ke menu");
            Console.ReadKey();
        }

        static void HapusMahasiswa()
        {
            Console.Clear();

            // PERINTAH: lengkapi kode untuk menghapus objek mahasiswa dari dalam collection
            Console.WriteLine("Hapus Data Mahasiswa");
            Console.WriteLine();
            Console.Write("NIM : ");
            string nim = Console.ReadLine();
            bool status = false;

            foreach (Mahasiswa mhs in daftar_mahasiswa)
            {
                if (mhs.npm == nim)
                {
                    daftar_mahasiswa.Remove(mhs);
                    Console.WriteLine();
                    Console.WriteLine("Data Mahasiswa berhasil di hapus");
                    status = true;
                    break;
                }
            }
            if (!status)
            {
                Console.WriteLine();
                Console.WriteLine("NIM not found");

            }

            Console.WriteLine("\nTekan ENTER untuk kembali ke menu");
            Console.ReadKey();
        }

        static void TampilMahasiswa()
        {
            Console.Clear();
            Console.WriteLine("Data Mahasiswa\n");

            int i = 1;
            foreach (Mahasiswa mhs in daftar_mahasiswa)
            {
                Console.WriteLine("{0}, {1}, {2}, {3}, {4}", i, mhs.npm, mhs.nama_mahasiswa, mhs.jenis_kelamin, mhs.IPK);
                i++;
            }

            Console.WriteLine("\nTekan enter untuk kembali ke menu");
            Console.ReadKey();
        }
    }
}
