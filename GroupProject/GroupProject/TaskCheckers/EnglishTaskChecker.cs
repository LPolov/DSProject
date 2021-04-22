using System;
using System.Collections.Generic;

namespace GroupProject.TaskCheckers
{
    public class EnglishTaskChecker : TaskChecker
    {
        private String[] responseTimeAns = { "Ok", "Not ok" };
        public EnglishTaskChecker()
        {
        }

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

        public void checkResponseTime() {
            Console.WriteLine("Response time: " + responseTimeAns[new Random().Next(2)]);
        }
    }
}
