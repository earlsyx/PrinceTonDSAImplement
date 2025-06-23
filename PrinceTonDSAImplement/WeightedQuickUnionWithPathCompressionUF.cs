public class WeightedQuickUnionWithPathCompressionUF
{
    private int[] id; // parent links
    private int[] size; // size of tree rooted at i

    public WeightedQuickUnionWithPathCompressionUF(int n)
    {
        id = new int[n];
        size = new int[n];

        for(int i = 0; i < n; i++)
        {
            id[i] = i;
            size[i] = 1;
        }
    }

    //Find root of I with path compression
    public int Root(int i)
    {
        while (i != id[i])
        {
            id[i] = id[id[i]]; // path compression: point to the grand parent
            i = id[i];
        }
        return i;
    }

    // Are p and q connected
    public bool Connected(int p, int q)
    {
        return Root(p) == Root(q);
    }

    // Weighted Union
    public void Union(int p, int q)
    {
        int rootP = Root(p);
        int rootQ = Root(q);

        if (rootP == rootQ) return;

        if (size[rootP] < size[rootQ])
        {
            id[rootP] = rootQ;
            size[rootQ] += size[rootP];
        }
        else
        {
            id[rootQ] = rootP;
            size[rootP] += size[rootQ];
        }
    }

    // Debug: print parent and size arrays
    public void Print()
    {
        Console.WriteLine("id[]:   " + string.Join(", ", id));
        Console.WriteLine("size[]: " + string.Join(", ", size));
    }

}