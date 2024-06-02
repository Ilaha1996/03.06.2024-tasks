namespace _03._06._2024_task2;

internal class Program
{
    static void Main(string[] args)
    {
        {
            Car[] cars = new Car[2];

            cars[0] = new Car
            {
                BrandName = "Mercedes",
                Model = "E class",
                Type = Types.Sedan
            };

            cars[1] = new Car
            {
                BrandName = "BMW",
                Model = "X6",
                Type = Types.Suv
            };

            foreach (Car car in cars)
            {
                Console.WriteLine(car);
            }
        }
    }


}


