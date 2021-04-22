using System;
using System.Collections.Generic;
using GroupProject.Tasks;

namespace GroupProject
{
    public interface TaskFactory
    {
        private static Dictionary<String, TaskFactory> factories = new Dictionary<string, TaskFactory>();
        
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

        public abstract Task createTask();
    }
}
