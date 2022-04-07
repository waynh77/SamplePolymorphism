
using Polymorphism;

Console.WriteLine("Polymorphism\n");

Penjumlahan penambah = new();
penambah.tambah(1, 2, 3);
penambah.tambah(10, 12);
penambah.tambah(13.5,4);

Pengurangan pengurang=new();
pengurang.kurang(10, 5);
pengurang.kurang(15, 5, 5);
pengurang.kurang(10.5, 4);

Console.ReadKey();