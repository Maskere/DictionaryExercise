using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionaryExercise
{
    public class Mechanic : Person
    {
        public Mechanic(string _name, string _phoneNumber, string _title, int _repairId) 
        { 
            Name = _name;
            PhoneNumber = _phoneNumber;
            Title = _title;
            RepairId = _repairId;
        }

        public override string ToString()
        {
            return $"Mekanikeren {Name} er uddannet i {Title}";
        }
    }
}
