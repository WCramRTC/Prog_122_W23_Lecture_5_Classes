using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog_122_W23_Lecture_5_Classes
{
    public class Student
    {

        // Fields
        public string FirstName;
        public string LastName;
        public double CSIGrade;
        public double GenEdGrade;

        // Constructor
        // How do you create a constructor?
        // Access modifer - ClassName - Parentheses
        // Default Constructor ( takes no arguments )
 
        // Constructors allow / restrict what is needed to create an object
        // Guarentee vales for fields with a constructor
        public Student(string firstName, string lastName, int CSI, int GenEd)
        {
            // How you assign values to fields
            FirstName = firstName;
            LastName = lastName;
            CSIGrade = CSI;
            GenEdGrade = GenEd;
        }

        // Create a second constructor
        public Student(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
            CSIGrade = -1;
            GenEdGrade = -1;
        }

        // Properties
        // Methods

    }
}
