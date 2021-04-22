using System;
namespace GroupProject.TaskCheckers
{
    public interface TaskChecker
    {
        public abstract bool checkTask(Task task, String[] studentAns);
    }
}
