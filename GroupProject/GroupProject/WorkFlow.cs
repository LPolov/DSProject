using System;
using System.Collections.Generic;

namespace GroupProject
{
    //This class implements Facade pattern.
    //It hides the functions calling from the user, allowing to call one function to demostrate how program works.
    public class WorkFlow
    {
        private College college;

        public WorkFlow(String name)
        {
            //College object is created and populated.
            college = new College(name);
        }

        //This method shows the part of the college's workflow
        public void demostrateWorkFlow() {

            Console.WriteLine("\n\n\n");

            /*Gets all teachers from the college and puts them into the list
             *(College contains 10 teachers with randomly generated names).*/
            List<Teacher> teachers = college.getTeachers();

            //Gets randon teacher from the List of teachers and prints a name
            Teacher teacher = teachers[new Random().Next(teachers.Count)];
            Console.WriteLine("Teacher's name: " + teacher.GetName());

            //Gets random group of this teacher (Each teacher has 3 groups. Each group contains 4 students.)
            Console.WriteLine("\nTeacher's random student group:");
            StudentGroup group = teacher.GetGroup();

            //Checking the avarage score of each student in previously selected group
            Console.WriteLine("\nChecking average scores of the given group:\n");
            foreach (Student student in group.getStudents())
            {
                Console.WriteLine(student.getName() + " has average score: " + student.getAverageScore());
            }

            Console.WriteLine("\nThis group decided to learn.");
            group.Learn();

            Console.WriteLine("\nTeacher starts working.");
            teacher.work();

            //Checking the avarage score of each student in previously selected group
            Console.WriteLine("\nChecking average scores of the given group:\n");
            foreach (Student student in group.getStudents())
            {
                Console.WriteLine(student.getName() + " has average score: " + student.getAverageScore());
            }
        }
    }
}
