using System;

namespace PersonDataManagement
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-------Welcome To Person Data Management Program------");
            PersonManagement management = new PersonManagement();
            bool end = true;
            Console.WriteLine("1.GetTopTwoRecords\n2.GetRecordBetween13to18\n3.End Of The Program");
            while (end)
            {
                Console.WriteLine("\nEnter Option For Exicute The Program");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        management.AddDefaultData();
                        management.GetTopRecords();
                        break;
                    case 2:
                        management.AddDefaultData();
                        management.GetRecords();
                        break;
                }
            }
        }
    }
}