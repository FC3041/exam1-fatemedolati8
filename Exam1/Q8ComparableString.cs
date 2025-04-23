namespace Exam1;

public class Q8StringLengthComparer : IComparer<string>
{
    public int Compare(string? x, string? y)
    {
        int n1 = 0;
        int n2 = 0;
        if((x==null)&&(y==null))
        {
            return 0;
        }
        if(x==null)
        {
            return -1;
        }
        if(y==null)
        {
            return 1;
        }
        n1 = x.Length;
        n2 = y.Length;
        System.Console.WriteLine(n1);
        System.Console.WriteLine(n2);
        if(n1!=n2)
        {
            return n1.CompareTo(n2);
        }
        return x.CompareTo(y);
    }
}
public class Q8ComparableString
{
    public Q8ComparableString(string y)
    {
        this.y = y;
    }

    public string y { get; set; }
        public static int ca(string x,string y)
        {
            int n1 = 0;
            int n2 = 0;
            if ((x == null) && (y == null))
            {
                return 0;
            }
            if (x == null)
            {
                return -1;
            }
            if (y == null)
            {
                return 1;
            }
            n1 = x.Length;
            n2 = y.Length;
            System.Console.WriteLine(n1);
            System.Console.WriteLine(n2);
            if (n1 != n2)
            {
                return n1.CompareTo(n2);
            }
            return x.CompareTo(y);
        }
    public static bool operator<(Q8ComparableString a, Q8ComparableString b)
    {
        if(ca(a.y,b.y)<0)
        {
            return true;
        }
        return false;
    }
    public static bool operator >(Q8ComparableString a, Q8ComparableString b)
    {
        if (ca(a.y, b.y) > 0)
        {
            return true;
        }
        return false;
    }
    public static bool operator ==(Q8ComparableString a, Q8ComparableString b)
    {
        if (ca(a.y, b.y) == 0)
        {
            return true;
        }
        return false;
    }
    public static bool operator !=(Q8ComparableString a, Q8ComparableString b)
    {
        if (ca(a.y, b.y) != 0)
        {
            return true;
        }
        return false;
    }
}