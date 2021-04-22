using System;
using System.Collections.Generic;

namespace GroupProject.Tasks
{
    /*This class implements TaskFactory interface implementing Factory pattern.
     * It is used to create tasks for Java course.
    */
    public class JavaTaskGenerator : TaskFactory
    {
        /*This variable is used to store tasks.
         * On account of that fact that we do not want to get an access by index,
         * sort tasks, remove etc., but we just want to store all tasks together
         * in the resizable container and get an access to elements as fast as it possible
         * , we selected Stack. It is the fastest data structure with simple functionality.
         */
        private Stack<JavaTask> tasks = new Stack<JavaTask>();

        //When this object is created, it populated the stack with tasks.
        public JavaTaskGenerator()
        {
            PopulateTasks();
        }

        //This method is used to populate stack of tasks. It simply pushes tasks into the stack.
        private void PopulateTasks()
        {
            tasks.Push(new JavaTask("5 % 2 = ?", new String[] { "1", "2", "3", "4" }, new String[] { "1" }, "Java 1"));

            tasks.Push(new JavaTask("Choose classes that inherits Number class"
                , new String[] { "Integer", "Clonable", "Double", "System" }, new String[] { "Integer", "Double" }, "Java 2"));

            tasks.Push(new JavaTask("What inherits Object class?"
                , new String[] { "Every class", "No class", "System class", "Number class" }, new String[] { "Every class" }, "Java 3"));

            tasks.Push(new JavaTask("What is the output: System.outPrint(\"Hello!\")"
                , new String[] { "Error", "Excpetion", "Hello!", "Does not compile" }, new String[] { "Does not compile" }, "Java 4"));

            tasks.Push(new JavaTask("Why do we need Clonable interface?"
                , new String[] { "For fun", "To clone objects", "It does not exist", "I do not know" }, new String[] { "To clone objects" }, "Java 5"));

            tasks.Push(new JavaTask("Why do we need Comparable interface?"
                , new String[] { "For fun", "To clone objects", "To compare objects", "I do not know" }, new String[] { "To compare objects" }, "Java 6"));

            tasks.Push(new JavaTask("What is Inheritance?", new String[] { "Basic principle of OOP", "Class", "Interface", "Enum" }
            , new String[] { "Basic principle of OOP" }, "Java 7"));

            tasks.Push(new JavaTask("What is Polimorphism?", new String[] { "Basic principle of OOP", "Class", "Interface", "Enum" }
            , new String[] { "Basic principle of OOP" }, "Java8"));

            tasks.Push(new JavaTask("Choose the output of null.compareTo(null)", new String[] { "Error", "Excpetion", "Hello!", "Does not compile" }
            , new String[] { "Error" }, "Java 9"));

            tasks.Push(new JavaTask("Choose the number of iterations of while(true){}", new String[] { "1", "0", "10", "Infinity" }, new String[] { "Infinity" }, "Java 10"));
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
