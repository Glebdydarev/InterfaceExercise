using System;
namespace InterfaceExercise
{
    public class Car : IVehicle, ICompany
    {
        private bool isChanged;

        public Car()
        {
        }

        public bool Hastrunk { get; set; }
        public bool IsConvertible { get; set; }

        public bool HasLeatherSeats { get; set; }
        public double EngineSize { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public int SeatCount { get; set; }

        public string CompanyName { get; set; }
        public string Logo { get; set; }












    }
}
