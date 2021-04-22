using System;
using System.Collections.Generic;

namespace GroupProject.Tasks
{
    /*This class implements TaskFactory interface implementing Factory pattern.
     * It is used to create tasks for Sociable Skills course.
     */
    public class SociableTaskGenerator : TaskFactory
    {
        /*This variable is used to store tasks.
         * On account of that fact that we do not want to get an access by index,
         * sort tasks, remove etc., but we just want to store all tasks together
         * in the resizable container and get an access to elements as fast as it possible
         * , we selected Stack. It is the fastest data structure with simple functionality.
         */
        private Stack<SociableSkillsTask> tasks = new Stack<SociableSkillsTask>();

        //When this object is created, it populated the stack with tasks.
        public SociableTaskGenerator()
        {
            PopulateTasks();
        }

        /*This method is used to populate stack of tasks. It simply pushes tasks into the stack.
         */
        private void PopulateTasks()
        {
            tasks.Push(new SociableSkillsTask("Do you need to be angree to have friends?", new String[] { "Yes", "No" }, new String[] { "No" }, "Sociable Skills 1"));
            tasks.Push(new SociableSkillsTask("Do you need to be kind to have friends?", new String[] { "Yes", "No" }, new String[] { "Yes" }, "Sociable Skills 2"));
            tasks.Push(new SociableSkillsTask("Do you need to be sicoable to have friends?", new String[] { "Yes", "No", "Maybe" }, new String[] { "Maybe" }, "Sociable Skills 3"));
            tasks.Push(new SociableSkillsTask("Do you need friends?", new String[] { "Yes", "No", "Maybe" }, new String[] { "Maybe" }, "Sociable Skills 4"));
        }

        /*This method returns task from the stack. When the stack becomes empty 
         * it populates it.
         */
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
