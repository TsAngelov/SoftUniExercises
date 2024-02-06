using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftUniParking
{
    public class Parking
    {
        private List<Car> Cars;
        private int Capacity;

        public Parking(int capacity)
        {
            Cars = new List<Car>();
            Capacity = capacity;
        }

        public int Count => Cars.Count;

        public string AddCar(Car car)
        {
            if (Cars.Any(c => c.RegNumber == car.RegNumber))
            {
                return "Car with that registration number, already exists!";
            }
            if (Cars.Count() + 1 > Capacity)
            {
                return "Parking is full!";
            }
            Cars.Add(car);
            return $"Successfully added new car {car.Make} {car.RegNumber}";
        }

        public string RemoveCar(string registrationNumber)
        {
            Car car = Cars.FirstOrDefault(c => c.RegNumber == registrationNumber);

            if (car == null)
            {
                return "Car with that registration number, doesn't exist!";
            }
            Cars.Remove(car);
            return $"Successfully removed {registrationNumber}";
        }

        public Car GetCar(string registrationNumber)
        {
            return Cars.FirstOrDefault(c => c.RegNumber == registrationNumber);
        }

        public void RemoveSetOfRegistrationNumber(List<string> RegistrationNumbers)
        {
            Cars = Cars.Where(c => !RegistrationNumbers.Contains(c.RegNumber)).ToList();
        }
    }
}
