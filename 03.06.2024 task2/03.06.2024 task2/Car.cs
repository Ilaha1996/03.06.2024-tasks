namespace _03._06._2024_task2;

public class Car
{
    private static int Count;
    private int _id;
    private string _brandName;
    private string _model;
    private Types _type;

    public Car ()
    {
        Count++;
        _id = Count;
    }
    public int Id 
    {
        get { return _id; }
        
    }
    public string BrandName { get; set; }
    public string Model { get; set; }
    public Types  Type { get; set; }
    public override string ToString()
    {
        return $"ID - {Id}, Brand - {BrandName}, Model - {Model}, Type - {Type}";
    }

}
