using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftUniParking
{
    public class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int HorsePower { get; set; }
        public string RegNumber { get; set; }
        public Car(string make, string model, int hp, string regNumber)
        {
            Make = make;
            Model = model;
            HorsePower = hp;
            RegNumber = regNumber;
        }
        public override string ToString()
        {
            //return $"Make: {Make}\nModel: {Model}\nHorsePower: {HorsePower}\nRegistrationNumber: {RegNumber}";
            var sb = new StringBuilder();
            sb.AppendLine($"Make: {Make}");
            sb.AppendLine($"Model: {Model}");
            sb.AppendLine($"HorsePower: {HorsePower}");
            sb.Append($"RegistrationNumber: {RegNumber}");

            return sb.ToString();
        }
    }
}
