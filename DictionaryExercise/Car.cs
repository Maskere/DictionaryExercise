using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionaryExercise
{
    public class Car
    {
        Dictionary<int, AutoRepair> repairs;
        AutoRepair repair;
        private Owner owner;
        private static int idCounter = 0;
        
        private string regNo;
        private string make;
        private string model;
        private double totalCost;
        private int mileage;
        private int year;
        public int id;
        public Car(string _regNo, int _year,string _make,string _model,int _mileage)
        {
            idCounter++;
            id= idCounter;
            RegNo = _regNo;
            Year = _year;
            Make = _make;
            Model = _model;
            Mileage = _mileage;
            repair = Repair;
            repairs = new Dictionary<int, AutoRepair>();
            owner = Owner;
        }
        public string RegNo
        {
            get { return regNo; } 
            set {  regNo = value; }
        }
        public int Year
        {
            get { return year; }
            set {  year = value; }
        }
        public string Make
        {
            get { return make;}
            set {  make = value; }
        }
        public string Model
        {
            get { return model;}
            set {  model = value; }
        }
        public int Mileage
        {
            get { return mileage;}
            set {  mileage = value; }
        }
        public double TotalCost 
        { 
            get { return totalCost; } 
            set {  totalCost = value; } 
        }
        public AutoRepair Repair
        {
            get { return repair; }
            set { repair = value; }
        }
        public Owner Owner
        {
            get { return owner; }
            set { owner = value; }
        }
        public void AddAutoRepair(AutoRepair repair)
        {
             repairs.Add(repair.Id,repair);
        }
        public void PrintAllRepairs()
        {
            foreach (AutoRepair repair in repairs.Values)
            {
                if(repair != null)
                {
                    Console.WriteLine(repair);
                }
            }
        }
        public double TotalAutoRepairCost()
        {
            foreach (AutoRepair repair in repairs.Values)
            {
                totalCost = repair.Price;
            }
            return totalCost;
        }
        public override string ToString()
        {
            foreach (AutoRepair repair in repairs.Values)
            {
                Console.WriteLine("Reparation: "+repair);
            }
            string v = $"Bil {id} med registrerings nummer {RegNo},fra {Year}, {Make} {Model}, har kørt {Mileage} km. Denne bil har haft {repairs.Count} reparation(er) for {TotalCost} kr.";
            return v + $"\nDenne bil ejes af {Owner.Name}";
        }
    }
}
