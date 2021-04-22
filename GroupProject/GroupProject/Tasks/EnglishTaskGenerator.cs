using System;
using System.Collections.Generic;

namespace GroupProject.Tasks
{
    public class EnglishTaskGenerator : TaskFactory
    {
        private Stack<EnglishTask> tasks = new Stack<EnglishTask>();

        public EnglishTaskGenerator()
        {
            PopulateTasks();
        }

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
