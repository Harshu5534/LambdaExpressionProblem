using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonDataManagement
{
    public class PersonManagement
    {
        List<Person> personList = new List<Person>();
        public void AddDefaultData()
        {
            personList.Add(new Person { SSN = 1, Name = "Harshu", Address = "Dhule", Age = 28 });
            personList.Add(new Person { SSN = 2, Name = "Hemlata", Address = "Nashik", Age = 31 });
            personList.Add(new Person { SSN = 3, Name = "Harshali", Address = "Latur", Age = 70 });
            personList.Add(new Person { SSN = 4, Name = "Arun", Address = "Dhule", Age = 70 });
            personList.Add(new Person { SSN = 5, Name = "Girish", Address = "Shirpur", Age = 17 });
            personList.Add(new Person { SSN = 6, Name = "Rohit", Address = "Dhule", Age = 26 });
            personList.Add(new Person { SSN = 7, Name = "Manda", Address = "Warud", Age = 65 });
            personList.Add(new Person { SSN = 8, Name = "Harshit", Address = "Mumbai", Age = 16 });
        }
        public void Display(IEnumerable<Person> list)
        {
            foreach (var person in list)
            {
                Console.WriteLine(person.SSN + " " + person.Name + " " + person.Address + " " + person.Age);
            }
        }
        public void GetTopRecords()
        {
            var Result = this.personList.Where(x => x.Age < 60).Take(2);
            Display(Result);
        }
        public void GetRecords()
        {
            var result = this.personList.Where(x => x.Age > 13 && x.Age < 18);
            Display(result);
        }
        public void AvarageRecords()
        {
            var Result = this.personList.Average(x => x.Age);
            Console.WriteLine(Result);
        }
    }
}
