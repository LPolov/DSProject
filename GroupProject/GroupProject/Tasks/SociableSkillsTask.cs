using System;
namespace GroupProject.Tasks
{
    //This class is used to represent tasks for Sociable Skills course.
    public class SociableSkillsTask : Task
    {
        public SociableSkillsTask(String question, String[] variants, String[] answers, String name)
        {
            this.question = question;
            this.variants = variants;
            this.answers = answers;
            this.name = name;
        }
    }
}
