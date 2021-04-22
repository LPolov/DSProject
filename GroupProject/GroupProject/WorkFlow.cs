using System;
using System.Collections.Generic;

namespace GroupProject
{
    public class WorkFlow
    {
        private College college;

        public WorkFlow(String name)
        {
            college = new College(name);
        }

        public void demostrateWorkFlow() {
            Console.WriteLine("\n\n\n");
            List<Teacher> teachers = college.getTeachers();

            Teacher teacher = teachers[new Random().Next(teachers.Count)];
            Console.WriteLine("Teacher's name: " + teacher.GetName());

            Console.WriteLine("\nTeacher's random student group:");
            StudentGroup group = teacher.GetGroup();

            Console.WriteLine("\nChecking average scores of the given group:\n");
            foreach (Student student in group.getStudents())
            {
                Console.WriteLine(student.getName() + " has average score: " + student.getAverageScore());
            }

            Console.WriteLine("\nThis group decided to learn.");
            group.Learn();

            Console.WriteLine("\nTeacher starts working.");
            teacher.work();

            Console.WriteLine("\nChecking average scores of the given group:\n");
            foreach (Student student in group.getStudents())
            {
                Console.WriteLine(student.getName() + " has average score: " + student.getAverageScore());
            }
        }
    }
}
