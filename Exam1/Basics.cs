namespace Exam1;
public class Q1_Add
{
    public static int Add(int a,int b)
    {
        return a+b;
    }
 
}
public class Basics
{
    public static void Q2MultiplyAndReset(ref int a,ref int b)
    {
        a=a*b;
        b=1;
    }   
    public static void Q5TryCatchFinally(bool th_is,List<string> rule,bool is_ca)
    {
        if(th_is==true)
        {
            throw new InvalidOperationException();
        }
    }
    public static void Q5TryCatchFinally(bool is_ca,List<string> rule)
    {
        List < string > c= new();
        try
        {
            rule.Add("Try");
            string s = "aaaa";
            if(is_ca==true)
            {
                char a = s[6];
            }            
            rule.Add("AfterTry");
        }
        catch (IndexOutOfRangeException e)
        {

            rule.Add("Catch");
        }
        finally
        {
            rule.Add("Finally");

        }
    }
}

public struct Type1
{
    public int Count { get; set; }
}

public class Type2
{
    public int Count { get; set; }
}
public class Q4Person
{


    public string Name { get; set; }
    public int Age { get; set; }
    public Q4Person(string name, int age)
    {
        Name=name;
        Age=age;

    }
    public string Introduce()
    {
        return $"Hello, my name is {Name} and I am {Age} years old.";
    }
}
public class Q6Temperature
{
    private double celsius;
    private double fahrenheit;

    public double Celsius { get 
    {
       return celsius; 
    }  set
        {
            celsius = value;
            fahrenheit = 32 + (1.8 * celsius);
        }
    }
    public double Fahrenheit { get => fahrenheit; set
        {
            fahrenheit = value;
            celsius = (5 * ( fahrenheit-32))/9;
        }

    }

    }
public interface IShape
{
    double GetArea();
    double GetPerimeter();
}
public class Q7Circle:IShape
{
    public Q7Circle(double r)
    {
        R = r;
    }

    public double R { get; set; }

    public double GetArea()
    {
        
       return Math.PI * R * R;
    }

    public double GetPerimeter()
    {
        
         return 2 * Math.PI * R;
    }
}
public class Q7Rectangle : IShape
{
    public Q7Rectangle(double x, double y)
    {
        this.x = x;
        this.y = y;
    }

    public double x { get; set; }
    public double y { get; set; }

    public double GetArea()
    {
        
        return x * y;
    }

    public double GetPerimeter()
    {
        return 2 * (x + y);
    }
}
public class ShapeUtils
{
    public static double Q7TotalArea(IShape[] x)
    {
        double sum = 0;
        for(int i=0;i<x.Length;i++)
        {
            sum += x[i].GetArea();
        }
        return sum;
    }
}