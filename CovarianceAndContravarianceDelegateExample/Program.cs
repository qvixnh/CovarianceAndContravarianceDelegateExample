using System;
using System.IO;
using System.Linq;
namespace CovarianceAndContravarianceDelegateExample
{
    class Program
    {
        delegate Car CarFactoryDel(int id, string name);
        delegate void LogICECarDetailsDel(ICECar car);
        delegate void LogEVCarDetailsDel(EVCar car);

        static void Main(string[] args)
        {
            //ICE Car
            CarFactoryDel carFactoryDel = CarFactory.ReturnICECar;
            Car iceCar = carFactoryDel(1,"Audi R8");
            
            //EV Car
            carFactoryDel = CarFactory.ReturnEVCar;
            Car evCar = carFactoryDel(2, "Tesla Model-3");
            LogICECarDetailsDel logICECarDetailsDel = LogCarDetails;
            logICECarDetailsDel(iceCar as ICECar);
            LogEVCarDetailsDel logEVCarDetailsDel = LogCarDetails;
            logEVCarDetailsDel(evCar as EVCar);
            Console.WriteLine();
            Console.ReadKey();

        }
        static void LogCarDetails(Car car)
        {
            if(car is ICECar)
            {
                using (StreamWriter sw = new StreamWriter(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "ICEDetails.txt"), true))
                {
                    sw.WriteLine($"Object Type: {car.GetType()}");
                    sw.WriteLine($"Car Details: {car.GetCarDetails()}");
                }
            }
            else if (car is EVCar)
            {
                Console.WriteLine($"Object Type: {car.GetType()}");
                Console.WriteLine($"Car Details: {car.GetCarDetails}");
            }
            else
            {
                throw new ArgumentException();
            }
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