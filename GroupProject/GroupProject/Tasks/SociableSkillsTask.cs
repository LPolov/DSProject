using System;
namespace GroupProject.Tasks
{
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
