using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace track_emply
{
    public class Employ : People
    {
        //Hire date
        //Termination date
        //Pay rate
        //Pay grade
        //Hours worked
        //Department
        DateTime hireDate;
        DateTime termDate;
        double payRate;
        int grade;
        Depart department;
        

        public int Grade
        {
            get
            {
                return grade;
            }
            set
            {
                grade = value;
            }

        }

        public virtual void ChangeGrade(int newGrade)
        {
            grade = newGrade;
        }

        public virtual void Hired(DateTime hDate)
        {

            hireDate = hDate.AddYears(-1);
            
        }

        public virtual void Fired()
        {

           termDate = DateTime.Today; ;
        }

        public double  Raise(Double money)
        {

           payRate = money * 1.04;
            return payRate;
        }

        

       



    }
}
