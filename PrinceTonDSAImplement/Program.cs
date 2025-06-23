using System;

class Program
{
    static void Main()
    {
        var uf = new QuickFindUF(10); // This should work now!

        uf.Union(4, 3);
        uf.Union(3, 8);
        uf.Union(6, 5);
        uf.Union(9, 4);
        uf.Union(2, 1);

        Console.WriteLine(uf.Connected(8, 9)); // True
        Console.WriteLine(uf.Connected(5, 4)); // False

        uf.Print();

        Console.ReadLine(); // Pause the console
    }
}
