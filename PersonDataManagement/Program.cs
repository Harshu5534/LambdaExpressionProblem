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
            Console.WriteLine("1.GetTopTwoRecords\n2.GetRecordsBetween13to18\n3.AvarageRecords\n4.End Of The Program");
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
                    case 3:
                        management.AddDefaultData();
                        management.AvarageRecords();
                        break;
                    case 4:
                        end = false;
                        Console.WriteLine("Program Is Ended.");
                        break;
                    default:
                        Console.WriteLine("Enter The Correct Option");
                        break;
                }
            }
        }
    }
}