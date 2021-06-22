namespace Börse
{
    public interface IRevenue
    {
        double coin { get; set; }
        double usd_day { get; set; }
        double usd_month { get; set; }
        double usd_week { get; set; }
    }
}