using System;
using System.IO;
using System.Linq;
namespace CovarianceAndContravarianceDelegateExample
{
    class Program
    {
        static void Main(string[] args)
        {

        }
        
    }
    //factory pattern 
    public static class CarFactory
    {
        public static ICECar ReturnICECar(int id, string name)
        {
            return new ICECar { Id = id, Name = name };

        }
        public static EVCar ReturnEVCar(int id, string name) { 
            return new EVCar { Id = id,Name = name };
        }
    }

    public abstract class Car
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual string GetCarDetails()
        {
            return $"{Id} - {Name}";
        }
    }
    public class ICECar: Car
    {
        public override string GetCarDetails()
        {
            return $"{base.GetCarDetails()} - Internal Combustion Engine";
        }
    }
    public class EVCar: Car
    {
        public override string GetCarDetails()
        {
            return $"{base.GetCarDetails()} - Electric";
        }
    }
}