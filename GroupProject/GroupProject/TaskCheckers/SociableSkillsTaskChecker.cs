using System;
using System.Collections.Generic;

namespace GroupProject.TaskCheckers
{
    public class SociableSkillsTaskChecker : TaskChecker
    {
        String[] ans = new String[] {"I like it.", "So-so", "Great!" };
        public SociableSkillsTaskChecker()
        {
        }

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

        public void check() {
            Console.WriteLine("Additional checking: " + ans[new Random().Next(3)]);
        }
    }
}
