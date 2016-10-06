using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace track_emply
{
    class Program
    {
        static void Main(string[] args)
        {
            //Creating and changing departments
            Depart myDeptN = new Depart();
            myDeptN.DeptName = "Project Managers";
            myDeptN.ChangeDeptName("Senior Project Managers");
            Depart myDeptN2 = new Depart();
            myDeptN2.DeptName = "Front End Developer";
            myDeptN2.ChangeDeptName("Senior Front End Developer");

            Console.WriteLine("We have two departments: " + myDeptN.DeptName + " and " + myDeptN2.DeptName);
            
            //Creating employees name
            Employ employee1 = new Employ();
            Employ employee2 = new Employ();
            Employ employee3 = new Employ();
            Employ employee4 = new Employ();
            Employ employee5 = new Employ();
            employee1.FirstN ="John";
            employee1.LastN = "Smith";
            employee2.FirstN = "Snow";
            employee2.LastN = "White";
            employee3.FirstN = "Wall";
            employee3.LastN = "E";
            employee4.FirstN = "Buzz";
            employee4.LastN = "Lightyear";
            employee5.FirstN = "Winnie";
            employee5.LastN = "Pooh";
            //Changing employee 5's name
            employee5.ChangeName("Lama", "TheGreat");

            Employ[] myArray = new Employ[5];
            myArray[0] = employee1;
            myArray[1] = employee2;




            Console.WriteLine(employee1.FirstN + " " + employee1.LastN);

            //Grade Employee
            employee1.Grade = 9;
            employee2.Grade = 13;
            employee3.Grade = 20;
            employee4.Grade = 10;
            employee5.Grade = 8;


            //Promoting Employee
            //Square square2 = new Square(5);
            //double valueOfAreaCalculation = square2.Area();

            double employ4Raise = employee3.Raise(120000);
            employee3.ChangeGrade(25);
            //get and set

            Console.WriteLine(employ4Raise);
            Console.WriteLine("Wall-E received a promotion from grade 20 to "+ employee3.Grade + " and a 4% raise making his total salary " + employ4Raise );
            Utils.Pay(myArray);



            Console.ReadLine();

        }
    }
}
