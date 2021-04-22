using System;
using System.Collections.Generic;

namespace GroupProject
{
    public class StudentGroup : Learnable
    {
        private static int groupNumberCounter;
        private LinkedList<Student> students;
        private static int groupNumber;
        private GroupDetails details;

        public StudentGroup(LinkedList<Student> students, GroupDetails details)
        {
            this.students = students;
            groupNumber = groupNumberCounter++;
            this.details = details;
        }

        public LinkedList<Student> getStudents() {
            return students;
        }

        public GroupDetails GetGroupDetails() { return details; }

        public void Learn()
        {
            foreach (Student student in students)
                student.Learn();
        }
    }
}
