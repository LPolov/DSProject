using System;
namespace GroupProject.TaskCheckers
{
    /*This class is used to implement Decorator pattern.
     * It extends TaskChecker interface and overrides checkTask method.
     */
    public class TaskCheckerDecorator : TaskChecker
    {
        /*This field is used to store TaskChecker object.
         * It stores diffent types of TaskChecker objects
         * depending on the type of task to check.
         */
        protected TaskChecker taskChecker;

        public TaskCheckerDecorator(TaskChecker taskChecker)
        {
            this.taskChecker = taskChecker;
        }

        /*This method calls checkTask method of taskChecker field.
         * This allows to call checkTask method of one TaskCheckerDecorator,
         * not creating new TaskChecker object for different types of tasks.
         */
        public bool checkTask(Task task, String[] studentAns) {
            return taskChecker.checkTask(task, studentAns);
        }
    }
}
