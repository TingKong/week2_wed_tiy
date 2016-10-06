using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace track_employ
{
    class Program
    {
        static void Main(string[] args)
        {
            Depart myDeptN = new Depart();
            
            myDeptN.DeptName = "Project Managers";
            myDeptN.ChangeDeptName("Project Managers");
            
            //myDeptN2.DeptName = "Front End Developers";
            Console.WriteLine("We have two departments:" + myDeptN + " and " + myDeptN );

            Console.ReadLine();

        }
    }
}
