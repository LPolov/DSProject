using System;
namespace GroupProject.TaskCheckers
{
    //This interface is used to implement Decorator and Factory patterns.
    //It has a base method of all TaskCheckers.
    public interface TaskChecker
    {
        public abstract bool checkTask(Task task, String[] studentAns);
    }
}
