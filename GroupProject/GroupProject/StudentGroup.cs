using System;
using System.Collections.Generic;

namespace GroupProject
{
    //This class represents a group of students in the college and implements Composite pattern.
    public class StudentGroup : Learnable
    {
        private static int groupNumberCounter;

        //Linked list is used because we do not need to have an access by the index.
        private LinkedList<Student> students;

        //this variable is used to give unique number to each group
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

        //Method allows to call Learn method from each student in the group.
        //It is allowed because we have implemented Composite pattern.
        public void Learn()
        {
            foreach (Student student in students)
                student.Learn();
        }
    }
}
