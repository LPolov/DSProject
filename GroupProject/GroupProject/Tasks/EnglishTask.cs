using System;
namespace GroupProject.Tasks
{
    public class EnglishTask : Task
    {
        public EnglishTask(String question, String[] variants, String[] answers, String name)
        {
            this.question = question;
            this.variants = variants;
            this.answers = answers;
            this.name = name;
        }
    }
}
