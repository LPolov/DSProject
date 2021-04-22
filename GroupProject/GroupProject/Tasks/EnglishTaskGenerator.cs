using System;
using System.Collections.Generic;

namespace GroupProject.Tasks
{
    /*This class implements TaskFactory interface implementing Factory pattern.
     * It is used to create tasks for English course.
    */
    public class EnglishTaskGenerator : TaskFactory
    {
        /*This variable is used to store tasks.
         * On account of that fact that we do not want to get an access by index,
         * sort tasks, remove etc., but we just want to store all tasks together
         * in the resizable container and get an access to elements as fast as it possible
         * , we selected Stack. It is the fastest data structure with simple functionality.
         */
        private Stack<EnglishTask> tasks = new Stack<EnglishTask>();

        //When this object is created, it populated the stack with tasks.
        public EnglishTaskGenerator()
        {
            PopulateTasks();
        }

        //This method is used to populate stack of tasks. It simply pushes tasks into the stack.
        private void PopulateTasks()
        {
            tasks.Push(new EnglishTask("Is word \"compleate\" correct?", new String[] { "Yes", "No" }, new String[] { "No" }, "English 1"));
            tasks.Push(new EnglishTask("Is word \"final\" correct?", new String[] { "Yes", "No" }, new String[] { "Yes" }, "English 2"));
            tasks.Push(new EnglishTask("Is word \"Elefant\" correct?", new String[] { "Yes", "No" }, new String[] { "No" }, "English 3"));
            tasks.Push(new EnglishTask("Is word \"Tiger\" correct?", new String[] { "Yes", "No" }, new String[] { "Yes" }, "English 4"));
            tasks.Push(new EnglishTask("Is word \"complete\" correct?", new String[] { "Yes", "No" }, new String[] { "Yes" }, "English 5"));
            tasks.Push(new EnglishTask("Is word \"probe\" correct?", new String[] { "Yes", "No" }, new String[] { "Yes" }, "English 6"));
            tasks.Push(new EnglishTask("Is word \"Look\" correct?", new String[] { "Yes", "No" }, new String[] { "Yes" }, "English 7"));
            tasks.Push(new EnglishTask("Is word \"Jarr\" correct?", new String[] { "Yes", "No" }, new String[] { "No" }, "English 8"));
            tasks.Push(new EnglishTask("Is word \"right\" correct?", new String[] { "Yes", "No" }, new String[] { "Yes" }, "English 9"));
            tasks.Push(new EnglishTask("Is word \"left\" correct?", new String[] { "Yes", "No" }, new String[] { "Yes" }, "English 10"));
        }

        /*This method returns task from the stack. When the stack becomes empty 
         * it populates it.
         */
        public Task createTask()
        {
            if (tasks.Count > 0) return tasks.Pop();
            else
            {
                PopulateTasks();
                return tasks.Pop();
            }
        }
    }
}
