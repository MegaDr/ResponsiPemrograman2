using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectCustomer
{
    class Program
    {
        // deklarasi objek collection untuk menampung objek customer
        static List<Customer> daftarCustomer = new List<Customer>();

        static void Main(string[] args)
        {
            Console.Title = "Responsi UAS Matakuliah Pemrograman";

            while (true)
            {
                TampilMenu();

                Console.Write("\nNomor Menu [1..4]: ");
                int nomorMenu = Convert.ToInt32(Console.ReadLine());

                switch (nomorMenu)
                {
                    case 1:
                        TambahCustomer();
                        break;

                    case 2:
                        HapusCustomer();
                        break;

                    case 3:
                        TampilCustomer();
                        break;

                    case 4: // keluar dari program
                        return;

                    default:
                        break;
                }
            }
        }

        static void TampilMenu()
        {
            Console.Clear();

            // PERINTAH: lengkapi kode untuk menampilkan menu
            Console.WriteLine("Pilih Menu Aplikasi");
            Console.WriteLine("1. Tambah Customer");
            Console.WriteLine("2. Hapus Customer");
            Console.WriteLine("3. Tampil Customer");
            Console.WriteLine("4. Keluar");
           
        }

        static void TambahCustomer()
        {
            Console.Clear();
            Customer customer = new Customer();
            Console.WriteLine("Tambah Data Customer");
            Console.Write("Kode Customer : ");
            string kode = Console.ReadLine();
            Console.Write("Nama Customer : ");
            string nama = Console.ReadLine();
            Console.Write("Total Piutang : ");
            int utang = int.Parse(Console.ReadLine());

            daftarCustomer.Add(new Customer { Kode = kode, Nama = nama, Utang = utang });
            
            Console.WriteLine("\nTekan ENTER untuk kembali ke menu");
            Console.ReadKey();
        }

        static void HapusCustomer()
        {
            Console.Clear();
            // PERINTAH: lengkapi kode untuk menambahkan customer ke dalam collection
            Console.WriteLine("Hapus data customer\n");
            Console.Write("Kode customer: ");
            string kodehapus = Console.ReadLine();
            if (daftarCustomer.Any(a => a.Kode == kodehapus))
            {
                daftarCustomer.RemoveAll(b => b.Kode == kodehapus);
                Console.WriteLine("\nData customer berhasil dihapus\n");
            }
            else
            {
                Console.WriteLine("Kode customer tidak ditemukan\n");
            }
            Console.WriteLine("\nTekan ENTER untuk kembali ke menu");
            Console.ReadKey();
        }

        static void TampilCustomer()
        {
            Console.Clear();

            // PERINTAH: lengkapi kode untuk menampilkan daftar customer yang ada di dalam collection
            int noUrut = 1;
            foreach (Customer customer in daftarCustomer)
            {
                Console.WriteLine("{0}. {1}, {2}, {3:N0}", noUrut, customer.Kode, customer.Nama, customer.Utang);
                noUrut++;
            }

            Console.WriteLine("\nTekan enter untuk kembali ke menu");
            Console.ReadKey();
        }
    }
}
