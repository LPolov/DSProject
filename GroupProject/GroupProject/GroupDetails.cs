using System;
using System.Collections;
using System.Collections.Generic;

namespace GroupProject
{
    public class GroupDetails
    {
        private int semesterNumber;
        private LinkedList<Course> courses;
        private string programName;

        private static HashSet<GroupDetails> detailsList = new HashSet<GroupDetails>();

        private GroupDetails(int semesterNumber, LinkedList<Course> courses, string programName)
        {
            this.semesterNumber = semesterNumber;
            this.courses = courses;
            this.programName = programName;
        }

        public static GroupDetails getGroupDetails(int semesterNumber, LinkedList<Course> courses, string programName) {

            foreach (GroupDetails item in detailsList) {
                if (item.semesterNumber == semesterNumber && item.programName.Equals(programName)) {
                    return item;
                }
            }

            GroupDetails newDetails = new GroupDetails(semesterNumber, courses, programName);
            detailsList.Add(newDetails);
            return newDetails;
        }

        public LinkedList<Course> GetCourses() { return courses; }
    }
}
