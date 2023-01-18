using System;

namespace Properties_Hamilton_Dakota
{
    class Program
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="args"> List of Cars and their Make and Model </param>
        static void Main(string[] args)
        {
            Car car = new Car();
            car.Make = "Ford";
            car.Model = "Mustang";

            Console.WriteLine($"Make: {car.Make}, Model: {car.Model}");

            Car car2 = new Car();
            car2.Make = "Chevy";
            car2.Model = "Camero";

            Console.WriteLine($"Make: {car2.Make}, Model: {car2.Model}");

            Car car3 = new Car();
            car3.Make = "Kia";
            car3.Model = "Sportage";

            Console.WriteLine($"Make: {car3.Make}, Model: {car3.Model}");
        }
    }
}
