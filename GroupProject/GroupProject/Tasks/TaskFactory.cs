using System;
using GroupProject.Tasks;

namespace GroupProject
{
    public interface TaskFactory
    {
        public abstract Task createTask();
        public static TaskFactory createTaskByName(String name) {
            if (name.Equals("Math")) return new MathTaskGenerator();
            else if (name.Equals("Java")) return new JavaTaskGenerator();
            else if (name.Equals("English")) return new EnglishTaskGenerator();
            else return new SociableTaskGenerator();
        }
    }
}
