using System;
namespace GroupProject
{
    //This class represents student in the college and implements Composite pattern.
    public class Student : Learnable
    {
        private string name;

        //This static variable is needed to give each new student unique id
        private static int idCounter;

        //taskCounter is needed to calculate avarage score of a student
        private int taskCounter;
        private int id;
        private int overallScore;

        public Student(string name)
        {
            this.name = name;
            id = idCounter++;
        }

        public void Learn()
        {
            Console.WriteLine(name + " is learning something.");
        }

        public string getName() { return name; }

        public double getAverageScore() {
            if (taskCounter != 0) return overallScore / taskCounter;
            else return 0;
        }

        /*When student has finished a task and got 
         * random score this method is called to update overall score.
         */
        public void updateOverallScore(int score) {
            overallScore += score;
            taskCounter++;
        }

    }
}
