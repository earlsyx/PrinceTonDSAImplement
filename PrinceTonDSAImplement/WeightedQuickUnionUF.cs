public class WeightedQuickUnionUF
{
    private int[] id; // id[i] = parent of i
    private int[] size; //size[i] = number of nodes in tree rooted at i

    public WeightedQuickUnionUF(int n)
    {
        id = new int[n];
        size = new int[n];

        for (int i = 0; i < n; i++)
        {
            id[i] = i; // each node is initially its own parent (root)
            size[i] = 1; // each tree has size of 1;
        }
    }

    //Find th root of element i
    private int Root(int i)
    {
        while (i != id[i])
            i = id[i];
        return i;
    }

    // Are p and q connected?
    public bool Connected(int p, int q)
    {
        return Root(p) == Root(q);
    }

    // Weighted union: link root of smaller tree to root of larger tree
    public void Union(int p, int q)
    {
        int rootP = Root(p);
        int rootQ = Root(q);

        if (rootP == rootQ) return; // already connected

        //make smaller root point to a larger root.
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