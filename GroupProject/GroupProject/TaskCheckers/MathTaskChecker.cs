using System;
using System.Collections.Generic;

namespace GroupProject.TaskCheckers
{
    /*This class is used to check tasks of Math course.*/
    public class MathTaskChecker : TaskChecker
    {
        public MathTaskChecker()
        {
        }

        /*This method takes a task and student's answers for this task.
         * It gets all correct answers for this task via getAnswers method
         * and puts it into the list.
         * Then program checks if all student's answers corresponds to correct answers
         * for this task and if at least one doe not - method return false, else - true.
         */
        public bool checkTask(Task task, string[] studentAns)
        {
            Console.WriteLine("Math task checking");
            List<String> correctAns = new List<String>(task.getAnswers());

            for (int i = 0; i < studentAns.Length; i++)
            {
                if (!correctAns.Contains(studentAns[i])) return false;
            }
            return true;
        }
    }
}
