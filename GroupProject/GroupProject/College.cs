using System;
using System.Collections.Generic;

namespace GroupProject
{
    public class College
    {
        private string name;
        private List<Teacher> teachers;
        private List<Student> students;

        /*program name - key, linked list of courses - value;
         * We chose dictionary because we had to store pair of values together
         * and it is the bast way to do it.
         * Courses are stored in the linked list we do not need to have an access by index, 
         * but we can insert and delete courses from the program's course list faster than if we use array.
         * So, it allow to make future functionality faster in case if programmer decides to add function
         * to remoce courses from program's course list.
        */
        private Dictionary<String, LinkedList<Course>> programsAndCourses;

        public College(string name)
        {
            this.name = name;
            teachers = new List<Teacher>();
            students = new List<Student>();
            programsAndCourses = new Dictionary<string, LinkedList<Course>>();
            populateCollege();
        }
        
        /*This method populates teachers and students lists.
         * It contains two arrays, first contains first names, second - second names.
         * Also, method creates one array which contains program name, and another one contains courses names.
         */
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

        /*This method populates college with 100 students with names which are created by random
         * combination of elements from firstNames and lastNames arrays.
         * Also, it populates college with 10 teachers who also have random generated names.
         */
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


        /*   Method takes two arrays which have program and courses names respectively.
         * It goes through each program from programNames array and puts each program
         * and corresponding courses list of this program.
         * On account of that fact that each program has unique combination of courses,
         * for loop contains if statement. This statement allows to add specific 
         * courses depending on the name of the program.
         * After for loop programsAndCourses dictionary is filled by all programs and courses.
         */
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
