using System;
using System.Collections.Generic;

namespace GroupProject.TaskCheckers
{
    public class JavaTaskChecker : TaskChecker
    {
        private String[] sytaxAnswers = { "Syntax is pretty good!", "Syntax is good, but you have to work harder on it"
                , "Syntax is awful." };

        public JavaTaskChecker()
        {
        }

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

        public void checkSytax(Task task) {
            Console.WriteLine(sytaxAnswers[new Random().Next(3)]);
        }

        
    }
}
