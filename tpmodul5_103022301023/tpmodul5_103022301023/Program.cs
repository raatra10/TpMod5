using System;
namespace tpmodul5_103022301023
{
    class Program
    {
        static void Main(string[] args)
        {
            HaloGeneric halo = new HaloGeneric();
            Console.Write("Masukkan nama: ");
            string nama = Console.ReadLine();
            halo.SapaUser(nama);
            Console.ReadLine();
        }
    }
}
