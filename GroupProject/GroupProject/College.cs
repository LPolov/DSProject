using System;
using System.Collections.Generic;

namespace GroupProject
{
    public class College
    {
        private string name;
        private List<Teacher> teachers;
        private List<Student> students;
        private Dictionary<String, LinkedList<Course>> programsAndCourses;

        public College(string name)
        {
            this.name = name;
            teachers = new List<Teacher>();
            students = new List<Student>();
            programsAndCourses = new Dictionary<string, LinkedList<Course>>();
            populateCollege();
        }
        

        private void populateCollege() {
            String[] firstNames = { "Jack", "Sam", "Paul", "Mike", "Robert", "Lisa", "Kate"
                    , "Sarrah", "Nastya", "El", "Jessy", "Rose", "Rosanna", "Silver", "Ray", "Luiza", "El"
                    , "James", "Leontii", "Prithvi", "Sarrah", "Mike", "Rem", "Lev", "Andrew", "Rosa"
                    , "Rel", "Mels", "Leo", "Max", "Marshall", "John", "Ronald", "Mickey", "Sam"};

            String[] lastNames = {"Golden", "Whatson", "Hatson", "Polister", "Mirello"
                    , "Rickardo", "Maccowoy", "Rolaban", "Salivan", "Vachovski", "Sollo", "Pickaboo"
                    , "Rasty", "Polovinko", "Lambert", "Gray", "Pot", "Luck", "Johnson", "Jr.", "Lors"
                    , "Giggs", "Tolstoy", "Shock", "Scotch", "Fal", "Chuck", "Roberts", "Libovski", "Raw"
                    , "Suon", "Polannik", "McDonald", "Aliston", "London"};

            String[] programNames = { "Information Technology Solutions", "Java Development"
                    , "Biotechnology", "Computer Programming"};

            String[] coursesNames = { "Math", "Java", "English", "Sociable Skills"};

            populatePrograms(programNames, coursesNames);
            populateParticipants(firstNames, lastNames);
        }

        private void populateParticipants(String[] firstNames, String[] lastNames)
        {
            Random rand = new Random();

            for (int i = 0; i < 100; i++)
            {
                students.Add(new Student(firstNames[rand.Next(firstNames.Length)] + " " + lastNames[rand.Next(lastNames.Length)]));
            }

            for (int i = 0; i < 10; i++)
            {
                teachers.Add(new Teacher(this, firstNames[rand.Next(firstNames.Length)], lastNames[rand.Next(lastNames.Length)]));
            }
        }

        private void populatePrograms(String[] programNames, String[] coursesNames)
        {
            LinkedList<Course> courses;

            for (int i = 0; i < programNames.Length; i++)
            {
                if (programNames[i].Equals("Information Technology Solutions"))
                {
                    courses = new LinkedList<Course>();
                    courses.AddLast(new Course(coursesNames[0]));
                    courses.AddLast(new Course(coursesNames[2]));
                }
                else if (programNames[i].Equals("Java Development"))
                {
                    courses = new LinkedList<Course>();
                    courses.AddLast(new Course(coursesNames[0]));
                    courses.AddLast(new Course(coursesNames[1]));
                }
                else if (programNames[i].Equals("Biotechnology"))
                {
                    courses = new LinkedList<Course>();
                    courses.AddLast(new Course(coursesNames[2]));
                    courses.AddLast(new Course(coursesNames[3]));
                }
                else
                {
                    courses = new LinkedList<Course>();
                    courses.AddLast(new Course(coursesNames[0]));
                    courses.AddLast(new Course(coursesNames[1]));
                    courses.AddLast(new Course(coursesNames[2]));
                }
                programsAndCourses.Add(programNames[i], courses);
            }
        }

        public List<Teacher> getTeachers() { return teachers; }
        public List<Student> getStudents() { return students; }
        public String getName() { return name; }
        public Dictionary<String, LinkedList<Course>> getPrograms() { return programsAndCourses; }
    }
}
