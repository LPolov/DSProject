using System;
namespace GroupProject
{
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
