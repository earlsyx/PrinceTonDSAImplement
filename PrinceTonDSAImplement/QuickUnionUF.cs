public class QuickUnionUF
{
    private int[] id;

    //Constructor: each element is its own root
    public QuickUnionUF(int n)
    {
        id = new int[n];
        for (int i = 0; i < n; i++)
            id[i] = i;
    }

    //Find the root element i
    private int Root(int i)
    {
        while (i != id[i])
            i = id[i]; // Climb the tree , get teh partent
        return i;
    }

    //Are p and q connected? i.e., do they have the same root?
    public bool Connected(int p, int q)
    {
        return Root(p) == Root(q);
    }

    // Connect p and q by setting the root of p to point to root of q
    public void Union(int p, int q)
    {
        int rootP = Root(p);
        int rootQ = Root(q);
        id[rootP] = rootQ; // connect the roots
    }

    // Debug print: show parent links
    public void Print()
    {
        Console.WriteLine("Parent Links: " + string.Join(", ", id));
    }
}