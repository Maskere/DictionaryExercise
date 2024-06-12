using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionaryExercise
{
    public class AutoRepair
    {
        private int id;
        private string description;
        private double price;
        private Mechanic mechanic;
        public AutoRepair(string _description, double _price)
        {
            id = Id;
            Description = _description;
            Price = _price;
        }
        public int Id
        { 
            get { return id; } 
            set { id = value; } 
        }
        public string Description 
        { 
            get { return description; } 
            set { description = value; } 
        }
        public double Price 
        { 
            get { return price; }
            set {  price = value; }
        }
        public Mechanic Mechanic
        {
            get { return mechanic; }
            set { mechanic = value; }
        }
        public override string ToString()
        {
            return $"{Description}. Udført af {mechanic.Name}. Pris:{Price}";
        }
    }
}
