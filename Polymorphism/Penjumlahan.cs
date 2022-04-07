
namespace Polymorphism
{
    internal class Penjumlahan
    {
        public int tambah(int a,int b)
        {
            Console.WriteLine("Jumlah 2 bilangan");
            Console.WriteLine("Hasil jumlah dari {0}+{1}={2}", a, b, (a + b));
            return a + b;
        }

        public int tambah(int a,int b,int c)
        {
            Console.WriteLine("Jumlah 3 bilangan");
            Console.WriteLine("Hasil jumlah dari {0}+{1}+{2}={3}", a, b,c, (a + b+c));
            return a + b + c;
        }

        public double tambah(double d, int b)
        {
            Console.WriteLine("Jumlah 2 bilangan dengan tipe berbeda");
            Console.WriteLine("Hasil jumlah dari {0}+{1}={2}", d, b, (d + b));
            return d + b;
        }
    }
}
