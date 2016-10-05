using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace track_emply
{

    public abstract class People
    {

        protected DateTime dateBirth;
        protected string ssNumber;
        protected string fN;
        protected string lN;
        protected string changeName;
        protected string name;

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        public virtual void ChangeName(string firstName, string lastName)
        {
            this.fN = firstName;
            this.lN = lastName;

            string x = lastName + " " + firstName ;
            

        }

        
    }

    

       

    }


