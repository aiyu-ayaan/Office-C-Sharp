using System.ComponentModel.DataAnnotations;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
          var car = new MyCar("Toyota", "Corolla", 2020, 15000);
            Console.WriteLine($"Make: {car.Make}");
            Console.WriteLine($"Model: {car.Model}");
            Console.WriteLine($"Year: {car.Year}");
            Console.WriteLine($"Total Distance Covered: {car.TotalDistanceCovered} km");
            // Update the total distance covered
            car.TotalDistanceCovered += 500;
            Console.WriteLine($"Updated Total Distance Covered: {car.TotalDistanceCovered} km");
        }
    }


    class MyCar
    {
        private string _make;
        private string _model;
        private int _year;
        private int _totalDistanceCovered;
        // constructor
        public MyCar(string make, string model, int year, int totalDistanceCovered)
        {
            this._make = make;
            this._model = model;
            this._year = year;
            _totalDistanceCovered = totalDistanceCovered;
        }
        public string Make
        {
            get { return _make; }
        }
        public string Model
        {
            get { return _model; }
        }
        public int Year
        {
            get { return _year; }
        }

        public int TotalDistanceCovered
        {
            get { return _totalDistanceCovered; }
            set { _totalDistanceCovered = value; }
        }

    }
}