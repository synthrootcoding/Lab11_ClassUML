using System;
using System.Collections.Generic;

namespace Labb11_UML
{
    class Program
    {
        static void Main(string[] args)
        {
            Student Brian = new Student("Brian", "1337 Airport Rd", "Graphic Design", 2020, 14999.99);
            Student Rachel = new Student("Rachel", "710 Airplane Rd", "Illustration", 2021, 14599.99);
            Student Sam = new Student("Sam", "9000 Over Rd", "Digital Marketing", 2020, 16000.00);
            Staff Kakashi = new Staff("Kakashi", "1570 Woodward Ave", "Grand Circus: Detroit", 1000000.00);
            Staff Sephiroth = new Staff("Sephiroth", "40 Pearl St NW", "Grand Circus: Grand Rapids", 1000000.01);

            List<Person> PersonList = new List<Person>
            {
                Brian, Rachel, Kakashi, Sephiroth
            };

            for (int i = 0; i < PersonList.Count; i++)
            {
                Console.WriteLine(PersonList[i].ToString());

            }
            Console.WriteLine();
            Console.WriteLine("Add a person to the list\n");
            string memberName = GetUserInput("Member name: \n"); Console.WriteLine();
            string memberAddress = GetUserInput("Member address: \n"); Console.WriteLine();
            string staffOrStudent = GetUserInput("Staff or student?: \n").ToLower(); Console.WriteLine();
            if (staffOrStudent == "staff")
            {
                string staffSchool = GetUserInput("Staff school: \n"); Console.WriteLine();
                double staffPay = double.Parse(GetUserInput("Staff pay: \n")); Console.WriteLine();
                Person person = new Staff(memberName, memberAddress, staffSchool, staffPay);
                PersonList.Add(person);
            }
            if (staffOrStudent == "student")
            {
                string studentProgram = GetUserInput("Student program: \n"); Console.WriteLine();
                int studentYear = int.Parse(GetUserInput("Student schoolyear: \n")); Console.WriteLine();
                double studentFee = double.Parse(GetUserInput("Student fee: \n")); Console.WriteLine();
                Person person = new Student(memberName, memberAddress, studentProgram, studentYear, studentFee);
                PersonList.Add(person);
            }
            for (int i = 0; i < PersonList.Count; i++)
            {
                Console.WriteLine(PersonList[i].ToString());

            }
            Console.WriteLine();
        }
        public static string GetUserInput(string message)
        {
            Console.WriteLine(message);
            string UserInfo = Console.ReadLine();
            return UserInfo;
        }

        public static void AddPerson(bool confirm)
        {

        }
    }
}

