using System;

namespace Cars
{
    class Car // class defaults to internal. Properties and methods default to private
    {
        // Field does not have get or set (no defined accessors). Convention is to use private with it. It would also work to make this a property with a { get; private set; }
        // Convention is to name private fields/properties starting with underscore
        private int _milesDriven = 0;
        // Constructor is a specific type of method that is invoked when we bring a new instance of something into existence.
        // When calling new Car(), have to give it the parameters that exist in the constructor method.
        // Good for setting initial values
        public Car(int startingMiles)
        {
            _milesDriven = startingMiles;
        }
        public int TotalMiles
        {
            get
            {
                return _milesDriven;
            }
        }
        // Properties have accessors (getters and setters)
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public double Price { get; set; }


        // This is called a "computed property"
        // Getters and setters allow us to determine computed properties and read-only properties
        public string Description
        {
            get
            {
                return $"A {Year} {Make} {Model}";
            }
        }

        // Methods
        // void means method does not return anything
        public void Accelerate()
        {
            Console.WriteLine($"{Make} {Model} goes vroom");
        }

        public int CalculateAge()
        {
            int currentYear = DateTime.Now.Year;
            int carYear = Year;
            return currentYear - carYear;
        }

        public int Drive(int miles)
        {
            _milesDriven += miles;
            return _milesDriven;
        }
    }
}