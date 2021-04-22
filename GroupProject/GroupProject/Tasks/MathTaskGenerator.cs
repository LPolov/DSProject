using System;
using System.Collections.Generic;

namespace GroupProject
{
    /*This class implements TaskFactory interface implementing Factory pattern.
     * It is used to create tasks for Math course.
    */
    public class MathTaskGenerator : TaskFactory
    {
        /*This variable is used to store tasks.
         * On account of that fact that we do not want to get an access by index,
         * sort tasks, remove etc., but we just want to store all tasks together
         * in the resizable container and get an access to elements as fast as it possible
         * , we selected Stack. It is the fastest data structure with simple functionality.
         */
        private Stack<MathTask> tasks = new Stack<MathTask>();

        //When this object is created, it populated the stack with tasks.
        public MathTaskGenerator()
        {
            PopulateTasks();
        }

        //This method is used to populate stack of tasks. It simply pushes tasks into the stack.
        private void PopulateTasks() {
            tasks.Push(new MathTask("2 + 2 = ?", new String[] { "1", "2", "3", "4" }, new String[] { "4" }, "Math 1"));
            tasks.Push(new MathTask("2 * 2 = ?", new String[] { "1", "2", "3", "4" }, new String[] { "4" }, "Math 2"));
            tasks.Push(new MathTask("5 + 7 = ?", new String[] { "11", "12", "3", "45" }, new String[] { "12" }, "Math 3"));
            tasks.Push(new MathTask("2 - 1 = ?", new String[] { "5", "1", "-4", "4" }, new String[] { "1" }, "Math 4"));
            tasks.Push(new MathTask("10 / 2 = ?", new String[] { "5", "2", "3", "4" }, new String[] { "5" }, "Math 5"));
            tasks.Push(new MathTask("23 + 85 = ?", new String[] { "100", "21", "108", "95" }, new String[] { "108" }, "Math 6"));
            tasks.Push(new MathTask("60 * 1.5 = ?", new String[] { "45", "30", "15", "55" }, new String[] { "45" }, "Math 7"));
            tasks.Push(new MathTask("9 / 0.5 = ?", new String[] { "20", "28", "18", "4.5" }, new String[] { "18" }, "Math 8"));
            tasks.Push(new MathTask("20 - 45 = ?", new String[] { "50", "-50", "25", "-25" }, new String[] { "-25" }, "Math 9"));
            tasks.Push(new MathTask("50 / 50 = ?", new String[] { "50", "0", "1", "10" }, new String[] { "1" }, "Math 10"));
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
