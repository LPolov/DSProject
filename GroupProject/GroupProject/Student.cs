using System;
namespace GroupProject
{
    public class Student : Learnable
    {
        private string name;
        private static int idCounter;
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

        public void updateOverallScore(int score) {
            overallScore += score;
            taskCounter++;
        }

    }
}
