using System;
using PrinceTonDSAImplement;
class Program
{
    static void Main()
    {
        //var uf = new QuickFindUF(10); // n*2
        //var uf = new QuickUnionUF(10); // n
        //var uf = new WeightedQuickUnionUF(10); // log n
        //var uf = new WeightedQuickUnionWithPathCompressionUF(10); // mear constant log n

        //uf.Union(4, 3);
        //uf.Union(3, 8);
        //uf.Union(6, 5);
        //uf.Union(9, 4);
        //uf.Union(2, 1);

        //Console.WriteLine(uf.Connected(8, 9)); // True
        //Console.WriteLine(uf.Connected(5, 4)); // False

        //uf.Print();

        // --- 3 sum bruite force
        int[] numbers = { -2, -1, 0, 1, 2, 3 };
        var threeSum = new ThreeSumBruitForce();
        int result = threeSum.Count(numbers);

        Console.WriteLine($"Number of triplet that sum to 0: {result}");
        

        Console.ReadLine(); // Pause the console
    }
}
