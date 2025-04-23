namespace Exam1;
public interface takhfif
{
    double get();
}
public class NoDiscountStrategy : takhfif
{
    public double get()
    {
        return 0;
    }
}
public class PercentageDiscountStrategy:takhfif
{
    public PercentageDiscountStrategy(double d)
    {
        this.d = d;
    }

    public double d { get; set; }

    public double get()
    {
        return d;
    }
}

public class PricingEngine 
{
    public PricingEngine(takhfif x)
    {
        this.x = x;
    }

    public takhfif x { get; set; }
    public double CalculatePrice(double y)
    {
        if (x is NoDiscountStrategy)
        { return y; }

        PercentageDiscountStrategy n = (PercentageDiscountStrategy)x;

        return y-(y * n.d);
    }
    public void SetStrategy(takhfif x)
    {

        this.x = x;
    }
}