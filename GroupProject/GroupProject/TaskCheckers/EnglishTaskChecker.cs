using System;
using System.Collections.Generic;

namespace GroupProject.TaskCheckers
{
    /*This class is used to check tasks of English course.*/
    public class EnglishTaskChecker : TaskChecker
    {
        //Answers for additional checking
        private String[] responseTimeAns = { "Ok", "Not ok" };
        public EnglishTaskChecker()
        {
        }

        /*This method takes a task and student's answers for this task.
         * Firstly, it calls checkResponseTime method, extending the basic functionality
         * of checkTask method. This is possible because we used Decorator pattern.
         * After that it gets all correct answers for this task via getAnswers method
         * and puts it into the list.
         * Then program checks if all student's answers corresponds to correct answers
         * for this task and if at least one doe not - method return false, else - true.
         */
        public bool checkTask(Task task, string[] studentAns)
        {
            Console.WriteLine("English task checking");
            checkResponseTime();
            List<String> correctAns = new List<String>(task.getAnswers());

            for (int i = 0; i < studentAns.Length; i++)
            {
                if (!correctAns.Contains(studentAns[i])) return false;
            }
            return true;
        }

        /*This method additionally checks the time a student's response. 
         * It just simply takes a random string from "responseTimeAns" array and displays it.
         */
        public void checkResponseTime() {
            Console.WriteLine("Response time: " + responseTimeAns[new Random().Next(2)]);
        }
    }
}
