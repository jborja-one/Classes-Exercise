namespace Classes
{
    public class Program
    {
        static void Main(string[] args)
        {
            var car = new Car();
            car.Make = "Toyota";
            car.Model = "Camry";
            car.Year = 2021;

            Console.WriteLine($"Make: {car.Make}");
            Console.WriteLine($"Model: {car.Model}");
            Console.WriteLine($"Year: {car.Year}");

        }
    }
}
