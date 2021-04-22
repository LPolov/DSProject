using System;
using System.Collections.Generic;
using GroupProject.Tasks;

namespace GroupProject
{
    /*This interface allows to implement Flyweight based on Factory pattern.
     * It allows to return TasksFactories based on a name of a task.
     */
    public interface TaskFactory
    {
        /*factories variable contains factoried for each TaskFactory types.
         * It allows to implement Flyweight.
         * We used dictionary because we had to keep pairs of a course's name 
         * and TaskFactories for this types of tasks.
         * So, the key of this dictionary is a name of a course, 
         * the value - TaskFactory which creates tasks for this course.
         */
        private static Dictionary<String, TaskFactory> factories = new Dictionary<string, TaskFactory>();

        /*This method taked name of a course and then checks if
         * factories dictionary already has a TaskFactory for this course or not.
         * If it has - this factory is returned, else - new TaskFactory is created 
         * and placed into the dictionary, and then returned.
         */
        public static TaskFactory createTaskByName(String name) {
            switch (name) {
                case "Math":
                    if (!factories.ContainsKey(name)) factories.Add(name, new MathTaskGenerator());
                    return factories[name];
                case "Java":
                    if (!factories.ContainsKey(name)) factories.Add(name, new JavaTaskGenerator());
                    return factories[name];
                case "English":
                    if (!factories.ContainsKey(name)) factories.Add(name, new EnglishTaskGenerator());
                    return factories[name];
                default:
                    if (!factories.ContainsKey(name)) factories.Add(name, new SociableTaskGenerator());
                    return factories[name];
            }
        }

        //Abstract method which is implemented by TaskFactory implementations.
        public abstract Task createTask();
    }
}
