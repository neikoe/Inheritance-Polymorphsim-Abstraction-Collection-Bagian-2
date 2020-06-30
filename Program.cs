using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Hitung_Gaji_Karyawan.Classinduk;
using Hitung_Gaji_Karyawan.Classanak;
namespace Hitung_Gaji_Karyawan
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Tugas Lab 9 Andhika Bagus Ramadhan (19.11.2611)";
            int input;
            List<Karyawan> listKaryawan = new List<Karyawan>();
            do
            {
                Console.WriteLine("PILIH MENU");
                Console.WriteLine("________________________________________");
                Console.WriteLine("1.) TAMBAH DATA KARYAWAN.");
                Console.WriteLine("2.) TAMPILKAN DATA KARYAWAN");
                Console.WriteLine("3.) UBAH DATA KARYAWAN");
                Console.WriteLine("4.) HAPUS DATA KARYAWAN");
                Console.WriteLine("5.) SELESAI");
                Console.WriteLine("________________________________________");
                Console.Write("MASUKKAN PILIHAN: ");
                input = Convert.ToInt32(Console.ReadLine());
                switch (input)
                {
                    case 1:
                        Console.WriteLine("TAMBAH DATA KARYAWAN\n");
                        Console.WriteLine("JENIS KARYAWAN\n1. KARYAWAN TETAP. \n2. KARYAWAN HARIAN. \n3. SALES. ");
                        Console.Write("MASUKKAN PILIHAN: ");
                        int pil = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine();
                        switch (pil)
                        {
                            case 1:
                                Karyawantetap Karyawantetap = new Karyawantetap();
                                Console.Write("NIK: ");
                                Karyawantetap.nik = Console.ReadLine();
                                Console.Write("NAMA: ");
                                Karyawantetap.nama = Console.ReadLine();
                                Console.Write("GAJI BULANAN: ");
                                Karyawantetap.gajibulanan = Convert.ToDouble(Console.ReadLine());
                                listKaryawan.Add(Karyawantetap);
                                break;
                            case 2:
                                Karyawanharian Karyawanharian = new Karyawanharian();
                                Console.Write("NIK: ");
                                Karyawanharian.nik = Console.ReadLine();
                                Console.Write("NAMA: ");
                                Karyawanharian.nama = Console.ReadLine();
                                Console.Write("JAM KERJA: ");
                                Karyawanharian.jumlahjamkerja = Convert.ToInt32(Console.ReadLine());
                                Console.Write("UPAH PERJAM: ");
                                Karyawanharian.upahperjam = Convert.ToDouble(Console.ReadLine());
                                listKaryawan.Add(Karyawanharian);
                                break;
                            case 3:
                                Sales Sales = new Sales();
                                Console.Write("NIK: ");
                                Sales.nik = Console.ReadLine();
                                Console.Write("NAMA: ");
                                Sales.nama = Console.ReadLine();
                                Console.Write("JAM KERJA: ");
                                Sales.jumlahpenjualan = Convert.ToInt32(Console.ReadLine());
                                Console.Write("UPAH PERJAM: ");
                                Sales.komisi = Convert.ToDouble(Console.ReadLine());
                                listKaryawan.Add(Sales);
                                break;
                            default:
                                Console.WriteLine("PILIHAN YANG ANDA MASUKKAN SALAH.");
                                break;
                        }
                        break;
                    case 2:
                        int noUrut = 0;
                        string jenis = " ";
                        Console.WriteLine("DATA KARYAWAN\n");
                        foreach (Karyawan karyawan in listKaryawan)
                        {
                            if (karyawan is Karyawantetap)
                            {
                                jenis = "KARYAWAN TETAP";
                            }
                            else if (karyawan is Karyawanharian)
                            {
                                jenis = "KARYAWAN HARIAN";
                            }
                            else
                            {
                                jenis = "SALES";
                            }
                            noUrut++;
                            Console.WriteLine("NO.: {0}", noUrut);
                            Console.WriteLine("NIK: {0}", karyawan.nik);
                            Console.WriteLine("NAMA: {0}", karyawan.nama);
                            Console.WriteLine("GAJI: {0}", karyawan.gaji());
                            Console.WriteLine("JENIS KARYAWAN: {0}", jenis);
                            Console.WriteLine("\n");
                        }
                        if (noUrut < 1)
                        {
                            Console.WriteLine("DATA TIDAK ADA.");
                        }
                        break;
                    case 3:
                        int i;
                        Console.WriteLine("UBAH DATA.\n");
                        Console.Write("NIK: ");
                        string updatenik = Console.ReadLine();
                        
                        foreach (Karyawan karyawan in listKaryawan)
                        {
                                
                            if (karyawan.nik == updatenik)
                            {
                                    Console.WriteLine("NIK: {0}", karyawan.nik);
                                    Console.WriteLine("NAMA: {0}", karyawan.nama);

                                    Console.Write("NIK: ");
                                    karyawan.nik = Console.ReadLine();
                                    Console.Write("NAMA: ");
                                    karyawan.nama = Console.ReadLine();
                            }
                            else
                            {
                                Console.WriteLine("\nDATA TIDAK ADA.");
                            }
                        }
                        break;
                    case 4:
                        int no = -1, hapus = -1;
                        Console.WriteLine("HAPUS DATA KARYAWAN.\n");
                        Console.Write("NIK : ");
                        string nik = Console.ReadLine();
                        foreach (Karyawan karyawan in listKaryawan)
                        {
                            no++;
                            if (karyawan.nik == nik)
                            {
                                hapus = no;
                            }
                        }
                        if (hapus != -1)
                        {
                            listKaryawan.RemoveAt(hapus);
                            Console.WriteLine("\nDATA DIHAPUS.");
                        }
                        else
                        {
                            Console.WriteLine("\nDATA TIDAK ADA.");
                        }
                        break;
                    case 5:
                        break;
                    default:
                        Console.WriteLine("PILIHAN YANG ANDA MASUKKAN SALAH.");
                        break;
                }
                Console.WriteLine("\nBERHASIL.\n");
            }
            while (input != 5);
        }
    }
}
