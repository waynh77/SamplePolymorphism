
namespace Polymorphism
{
    internal class Pengurangan
    {
        public int kurang(int a, int b)
        {
            Console.WriteLine("Pengurangan 2 bilangan");
            Console.WriteLine("Hasil Pengurangan dari {0}-{1}={2}", a, b, (a - b));
            return a - b;
        }

        public int kurang(int a, int b, int c)
        {
            Console.WriteLine("Pengurangan 3 bilangan");
            Console.WriteLine("Hasil Pengurangan dari {0}+{1}+{2}={3}", a, b, c, (a - b - c));
            return a - b - c;
        }

        public double kurang(double d, int b)
        {
            Console.WriteLine("Pengurangan 2 bilangan dengan tipe berbeda");
            Console.WriteLine("Hasil Pengurangan dari {0}-{1}={2}", d, b, (d - b));
            return d + b;
        }
    }
}
