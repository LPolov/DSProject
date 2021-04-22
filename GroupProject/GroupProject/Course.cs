using System;
namespace GroupProject
{
    //This class represents courses in the program.
    public class Course
    {
        private string name;

        public Course(string name)
        {
            this.name = name;
        }

        public string getName() { return name; }
    }
}
