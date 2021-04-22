using System;
namespace GroupProject.TaskCheckers
{
    public class TaskCheckerDecorator : TaskChecker
    {
        protected TaskChecker taskChecker;

        public TaskCheckerDecorator(TaskChecker taskChecker)
        {
            this.taskChecker = taskChecker;
        }

        public bool checkTask(Task task, String[] studentAns) {
            return taskChecker.checkTask(task, studentAns);
        }
    }
}
