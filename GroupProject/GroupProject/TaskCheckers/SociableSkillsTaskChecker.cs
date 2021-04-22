using System;
using System.Collections.Generic;

namespace GroupProject.TaskCheckers
{
    /*This class is used to check tasks of Sociable Skills course.*/
    public class SociableSkillsTaskChecker : TaskChecker
    {
        //Answers for additional checking
        private String[] ans = new String[] {"I like it.", "So-so", "Great!" };
        public SociableSkillsTaskChecker()
        {
        }

        /*This method takes a task and student's answers for this task.
         * Firstly, it calls check method, extending the basic functionality
         * of checkTask method. This is possible because we used Decorator pattern.
         * After that it gets all correct answers for this task via getAnswers method
         * and puts it into the list.
         * Then program checks if all student's answers corresponds to correct answers
         * for this task and if at least one doe not - method return false, else - true.
         */
        public bool checkTask(Task task, string[] studentAns)
        {
            Console.WriteLine("Sociable Skills task checking");
            check();
            List<String> correctAns = new List<String>(task.getAnswers());

            for (int i = 0; i < studentAns.Length; i++)
            {
                if (!correctAns.Contains(studentAns[i])) return false;
            }
            return true;
        }

        /*This method additionally checks the task of the student. 
         * It just simply takes a random string from "ans" array and displays it.
         */
        public void check() {
            Console.WriteLine("Additional checking: " + ans[new Random().Next(3)]);
        }
    }
}
