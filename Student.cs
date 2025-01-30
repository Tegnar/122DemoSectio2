// Written by Ben Wilkins
//1/15/2025 Start Date



using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

namespace SpringProgram1
{

    public class Student
    {
        //class variables in camel case
        private int studentId = -1;
        private string firstName = "Some error: FName";
        private string middleName = "Some error: MName";
        private string lastName = "Some error: LName";
        private string major = "Some error: Majorly";

        //GPA is a calculated field so later in the semester 
        //private double gpa = 0.0;

        // get and sets Accessor Methods = gets and Mutator Methods = sets

        public string FirstName
        {
            // This is a very bare bones get and set
            // there could be a lot of code here
            // but this is week 0 so there isn't a lot of code here yet
            // the code would be for checking ranges and such
            get { return this.firstName; }
            set { this.firstName = value; }

        }
        public string MiddleName
        {
            get { return this.middleName; }
            set { this.middleName = value; }
        }
        public string LastName
        {
            get { return this.lastName; }
            set { this.lastName = value; }
        }
        public string Major
        {
            get { return this.major; }
            set { this.major = value; }
        }
        public int StudentId
        {
            get { return this.studentId; }
            set { this.studentId = value; }


        }
        //constructors

        public Student()
        {
            // This is the empty constructor
            //It is called the empty constructor because it has no parameters
            // Normally this is given to you behind the scenes
            // But once you make a constructor, the built in empty constructor disappears
        }
        public Student(int aStudentId, string aFirstName, string aLastName, string aMiddleName, string aMajor)
        {
            // This is called the Full Constructor
            // Because it has one parameter for each property
            // It constructs the entire thing
            this.studentId  = aStudentId;
            this.firstName  = aFirstName;
            this.middleName = aMiddleName;
            this.lastName   = aLastName;
            this.major      = aMajor;

        }
        public Student(int aStudentId, string aFirstName, string aLastName, string aMiddleName):this()
        {

        }


        //methods
        public override string ToString()
        {
            string message = "";
            message = message + "Student Id: "  + this.StudentId    + "\n";
            message = message + "First Name: "  + this.firstName    + "\n";
            message = message + "Middle Name: " + this.middleName   + "\n";
            message = message + "Last Name: "   + this.lastName     + "\n";
            message = message + "Major: "       + this.major        + "\n";
            return message;
        }
    }
}
