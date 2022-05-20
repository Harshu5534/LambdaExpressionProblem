using System;

namespace PersonDataManagement

{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-------Welcome To Person Data Management Program------");
            PersonManagement management = new PersonManagement();
            management.AddDefaultData();
            management.GetTopRecords();
        }
    }
}