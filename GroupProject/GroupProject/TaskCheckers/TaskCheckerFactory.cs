using System;
using GroupProject.Tasks;

namespace GroupProject.TaskCheckers
{
    public class TaskCheckerFactory
    {
        public TaskCheckerFactory()
        {
        }

        public static TaskChecker GetTaskChecker(Task task) {
            if (task is JavaTask) return new JavaTaskChecker();
            else if (task is MathTask) return new MathTaskChecker();
            else if (task is EnglishTask) return new EnglishTaskChecker();
            else return new SociableSkillsTaskChecker();
        }
    }
}
