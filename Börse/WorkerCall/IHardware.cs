namespace Börse
{
    public interface IHardware
    {
        string name { get; set; }
        int power { get; set; }
        int temp { get; set; }
    }
}