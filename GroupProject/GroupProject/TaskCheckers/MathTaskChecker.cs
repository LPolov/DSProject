using System;
using System.Collections.Generic;

namespace GroupProject.TaskCheckers
{
    public class MathTaskChecker : TaskChecker
    {
        public MathTaskChecker()
        {
        }

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
