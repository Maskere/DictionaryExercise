using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionaryExercise
{
    public class CarRegister
    {
        public List<Car> cars;
        private string name;
        private int cvr;
        public CarRegister()
        {
            name = Name;
            cvr = Cvr;
            cars = new List<Car>();
        }
        public string Name
        {
            get {  return name; }
            set {  name = value; }
        }
        public int Cvr
        {
            get { return cvr; }
            set {  cvr = value; }
        }
        public void AddCar(Car car)
        {
            if(!cars.Contains(car))
            {
                cars.Add(car);
            }
        }
        public void DeleteCar(int id)
        {
            foreach(Car car in cars)
            {
                if(car.id == id)
                {
                    cars.Remove(car);
                }
            }
        }
        public void AddRepairToCar(string regNo,AutoRepair newAutoRepair)
        {
            foreach (Car car in cars)
            {
                if(car.RegNo == regNo)
                { 
                    car.AddAutoRepair(newAutoRepair);
                }
            }
        }
        public void PrintAllCars()
        {
            foreach (Car car in cars)
            {
                if (cars != null)
                {
                    Console.WriteLine(car);
                }
                else
                {
                    Console.WriteLine("Der er ingen biler i registret");
                }
            }
        }
        public override string ToString()
        {
            return $"{Name}'s værksted. CVR.:{Cvr}\nDer er {cars.Count} bil(er) registreret.\n";
        }
    }
}
