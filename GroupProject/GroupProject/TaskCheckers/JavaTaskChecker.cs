using System;
using System.Collections.Generic;

namespace GroupProject.TaskCheckers
{
    /*This class is used to check tasks of Java course.*/
    public class JavaTaskChecker : TaskChecker
    {
        //Answers for additional syntax checking
        private String[] sytaxAnswers = { "Syntax is pretty good!", "Syntax is good, but you have to work harder on it"
                , "Syntax is awful." };

        public JavaTaskChecker()
        {
        }

        /*This method takes a task and student's answers for this task.
         * Firstly, it calls checkSytax method, extending the basic functionality
         * of checkTask method. This is possible because we used Decorator pattern.
         * After that it gets all correct answers for this task via getAnswers method
         * and puts it into the list.
         * Then program checks if all student's answers corresponds to correct answers
         * for this task and if at least one doe not - method return false, else - true.
         */
        public bool checkTask(Task task, String[] studentAns)
        {
            Console.WriteLine("Java task checking");
            checkSytax(task);
            List<String> correctAns = new List<String>(task.getAnswers());

            for (int i = 0; i < studentAns.Length; i++)
            {
                if (!correctAns.Contains(studentAns[i])) return false;
            }
            return true;
        }

        /*This method additionally checks the syntax of the student's answer. 
         * It just simply takes a random string from "sytaxAnswers" array and displays it.
         */
        public void checkSytax(Task task) {
            Console.WriteLine(sytaxAnswers[new Random().Next(3)]);
        }

        
    }
}
