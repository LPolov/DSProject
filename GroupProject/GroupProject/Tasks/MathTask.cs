using System;

namespace GroupProject
{
    //This class is used to represent tasks for Math course.
    public class MathTask : Task
    {
        public MathTask(String question, String[] variants, String[] answers, String name)
        {
            this.question = question;
            this.variants = variants;
            this.answers = answers;
            this.name = name;
        }
    }
}
