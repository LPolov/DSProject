using System.Collections.Generic;

namespace GroupProject
{
    /*GroupDetails class implements flyweight pattern based on singleton.
     * It is used to contain details for each group 
     * (like th number of semester, list of courses and program name).
     */
    public class GroupDetails
    {
        private int semesterNumber;
        private LinkedList<Course> courses;
        private string programName;

        /*HashSet is used to contain unique GroupDetails objects.
         * We used this structure, because we need to store unique
         * objects, and HashSet allows to do it. It did not put new object into itself
         * if it already has it.
        */
        private static HashSet<GroupDetails> detailsList = new HashSet<GroupDetails>();

        //pricate constructor to implement Flyweight based on singleton.
        private GroupDetails(int semesterNumber, LinkedList<Course> courses, string programName)
        {
            this.semesterNumber = semesterNumber;
            this.courses = courses;
            this.programName = programName;
        }

        /*This method returns GroupDetails objects
         * It checks if hash set already has GroupDetails object with given semester number
         * and program name (courses are not checked because GroupDetails college can contain student groups
         * which have the same program names, but differs by semester number. Also, if student groups have the 
         * same program number, they have the same course list. This all mean that group details can differ with 
         * program name and semester number only)
         */
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
