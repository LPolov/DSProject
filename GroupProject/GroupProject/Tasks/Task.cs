using System;
using System.Collections;
using System.Collections.Generic;

namespace GroupProject
{
    public abstract class Task
    {
        protected String question;
        protected String[] variants;
        protected String[] answers;
        protected String name;

        public String getName() {
            return name;
        }

        public String getQuestion()
        {
            return question;
        }

        public String[] getVariants()
        {
            return variants;
        }

        public String[] getAnswers()
        {
            return answers;
        }
    }
}
