﻿using System;

namespace GroupProject
{
    public class JavaTask : Task
    {
        public JavaTask(String question, String[] variants, String[] answers, String name)
        {
            this.question = question;
            this.variants = variants;
            this.answers = answers;
            this.name = name;
        }
    }
}
