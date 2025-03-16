using System;

namespace tpmodul5_103022300123
{
    class Program
    {
        static void Main(string[] args)
        {
            HaloGeneric halo = new HaloGeneric();
            Console.Write("Masukkan nama: ");
            string nama = Console.ReadLine();
            halo.SapaUser(nama);

            Console.Write("Masukkan NIM: ");
            string nim = Console.ReadLine();
            DataGeneric<string> dataNIM = new DataGeneric<string>(nim);
            dataNIM.PrintData();
            Console.ReadLine();
        }
    }
}
