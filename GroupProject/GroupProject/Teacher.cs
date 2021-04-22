using System;
using System.Collections.Generic;
using GroupProject.TaskCheckers;

namespace GroupProject
{
    public class Teacher
    {
        private College college;
        private string fName;
        private string lName;
        private List<StudentGroup> groups = new List<StudentGroup>();
        Queue<Task> tasks;

        public Teacher(College college, string fName, string lName)
        {
            this.college = college;
            this.fName = fName;
            this.lName = lName;
            tasks = new Queue<Task>();
            startSemester();
        }

        public void startSemester()
        {
            HashSet<Student> students;

            for (int i = 0; i < 3; i++)
            {
                students = new HashSet<Student>();

                while (students.Count < 4)
                {
                    students.Add(college.getStudents()[new Random().Next(college.getStudents().Count)]);
                }

                groups.Add(new StudentGroup(new LinkedList<Student>(students), createGroupDetails()));
            }
        }

        public GroupDetails createGroupDetails()
        {
            Random rand = new Random();
            List<String> programs = new List<String>(college.getPrograms().Keys);
            int semNum = rand.Next(1, 5);
            int progNum = rand.Next(programs.Count);
            LinkedList<Course> courses = college.getPrograms()[programs[progNum]];
            return GroupDetails.getGroupDetails(semNum, courses, programs[progNum]);
        }

        public void work() {
            Console.WriteLine(fName + " " + lName + " is working.");
            Console.WriteLine("\nGives tasks for all students in each group");
            for (int i = 0; i < groups.Count; i++)
            {
                Console.WriteLine("\nFor group " + (i + 1) + ":\n");
                createTasksForGroup(groups[i]);
                Console.WriteLine("\nEvaluating tasks:");
                for (int j = 0; j < groups[i].GetGroupDetails().GetCourses().Count; j++) {
                    foreach (Student currStudent in groups[i].getStudents())
                    {
                        evaluate(currStudent, tasks.Dequeue());
                    }
                }
            }
        }

        private void createTasksForGroup(StudentGroup group) {
            LinkedList<Course> courses = group.GetGroupDetails().GetCourses();
            TaskFactory taskFactory;
            Task task;

            foreach (Course course in courses) {
                taskFactory = TaskFactory.createTaskByName(course.getName());
                foreach (Student student in group.getStudents()) {
                    task = taskFactory.createTask();
                    Console.WriteLine(student.getName() + " got " + task.getName() + " task.");
                    tasks.Enqueue(task);
                }
            }
        }

        private void evaluate(Student student, Task task) {
            
            TaskCheckerDecorator decorator = new TaskCheckerDecorator(TaskCheckerFactory.GetTaskChecker(task));
            Boolean taskResult = decorator.checkTask(task
                , new String[] { task.getAnswers()[new Random().Next(task.getAnswers().Length)]}
                );
            int taskScore;
            if (taskResult)
            {
                taskScore = new Random().Next(70, 101);
                student.updateOverallScore(taskScore);
            }
            else {
                taskScore = new Random().Next(71);
                student.updateOverallScore(taskScore);
            }

            Console.WriteLine(student.getName() + " got " + taskScore + " for " + task.getName() + " task.");
        }

        public string GetName() { return fName + " " + lName; }

        public StudentGroup GetGroup(){ return groups[new Random().Next(groups.Count)];}

        public void addGroup(StudentGroup group){groups.Add(group);}

        public void addTask(Task task){tasks.Enqueue(task);}
    }
}
