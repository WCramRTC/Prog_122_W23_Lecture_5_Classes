using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Prog_122_W23_Lecture_5_Classes
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        // Take your database diagram, create at least one class from it
        List<Student> students = new List<Student>();

        public MainWindow()
        {
            InitializeComponent();

            Instructor breshna = new Instructor("Naim", "Breshna", "123445677");
            // Properties

            Student student = new Student("Will", "Cram");

            SchoolClass sc = new SchoolClass(breshna, student);


            string format = sc.Instructor.FirstName + " - " + sc.Student.FirstName;
      
            MessageBox.Show(format);
        }

        public void Example()
        {
            // Createa  new INSTANCE of a student object
            Student student = new Student("Breshna", "Naim", 110, 115);
            Student student2 = new Student("Will", "Cram");

            // How do I give my student a first name
            //student.FirstName = "Breshna";
            //student.LastName = "Naim";
            //student.CSIGrade = 110;
            //student.GenEdGrade = 115;

            students.Add(student);
            students.Add(student2);

            // What is the new Student() calling?
            // The default constructor of student

            // What happens to the default constructor when I make
            // A new constructor?

            MessageBox.Show(FormattedStudent(student2));

        }

        public string FormattedStudent(Student student)
        {
            string studentInformation = student.FirstName + " " + student.LastName + " - " + student.CSIGrade + " - " + student.GenEdGrade;

            return studentInformation;
        }

    }
}
