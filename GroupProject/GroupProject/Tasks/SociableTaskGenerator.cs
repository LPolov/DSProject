using System;
using System.Collections.Generic;

namespace GroupProject.Tasks
{
    public class SociableTaskGenerator : TaskFactory
    {
        private Stack<SociableSkillsTask> tasks = new Stack<SociableSkillsTask>();

        public SociableTaskGenerator()
        {
            PopulateTasks();
        }

        private void PopulateTasks()
        {
            tasks.Push(new SociableSkillsTask("Do you need to be angree to have friends?", new String[] { "Yes", "No" }, new String[] { "No" }, "Sociable Skills 1"));
            tasks.Push(new SociableSkillsTask("Do you need to be kind to have friends?", new String[] { "Yes", "No" }, new String[] { "Yes" }, "Sociable Skills 2"));
            tasks.Push(new SociableSkillsTask("Do you need to be sicoable to have friends?", new String[] { "Yes", "No", "Maybe" }, new String[] { "Maybe" }, "Sociable Skills 3"));
            tasks.Push(new SociableSkillsTask("Do you need friends?", new String[] { "Yes", "No", "Maybe" }, new String[] { "Maybe" }, "Sociable Skills 4"));
        }

        public Task createTask()
        {
            if (tasks.Count > 0) return tasks.Pop();
            else {
                PopulateTasks();
                return tasks.Pop();
            }
        }
    }
}
