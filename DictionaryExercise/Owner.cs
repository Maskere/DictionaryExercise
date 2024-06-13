using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionaryExercise
{
    //Owner klassen nedarver fra Person. Skal ikke lave 'properties', bare kald på dem fra klassen Person:
    public class Owner : Person
    {
        public Owner(string _name, string _phoneNumber, string _title, int _repairId) 
        { 
            Name = _name;
            PhoneNumber = _phoneNumber;
            Title = _title;
            RepairId = _repairId;
        }

        public override string ToString()
        {
            return $"Ejeren til reparation {RepairId}: {Name}";
        }
    }
}
