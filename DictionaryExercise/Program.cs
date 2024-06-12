namespace DictionaryExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            CarRegister carRegister = new CarRegister() { Name ="Miki",Cvr=123456};

            Car c1 = new Car("EB29351", 2020, "FORD", "FUGA", 25000);
            Car c2 = new Car("FT23433", 2010, "Tesla", "Model Y", 250000);

            AutoRepair repair1 = new AutoRepair("Skiftet venstre forhjul", 700) { Id = 1};
            AutoRepair repair4 = new AutoRepair("Motor skiftet", 27050) { Id = 4 };
            AutoRepair repair5 = new AutoRepair("Gearkassen skiftet", 67050) { Id = 5 };

            carRegister.AddCar(c1);
            carRegister.AddCar(c2);

            carRegister.AddRepairToCar("EB29351",repair1);
            carRegister.AddRepairToCar("FT23433", repair5);
            carRegister.AddRepairToCar("EB29351", repair4);
            carRegister.AddRepairToCar("EB29351", repair5);

            Owner owner1 = new Owner("Miki","40537194","Hr.",repair1.Id);
            c1.Owner = owner1;
            Mechanic mechanic1 = new Mechanic("Mark","12345678","Toyota",repair1.Id);
            repair1.Mechanic = mechanic1;
            repair4.Mechanic = mechanic1;
            repair5.Mechanic = mechanic1;

            c1.TotalAutoRepairCost();
            Console.WriteLine(c1);
        }
    }
}
