using System;
using System.Collections.Generic;
using GroupProject.TaskCheckers;

namespace GroupProject
{
    //This class represents a teacher in the college.
    public class Teacher
    {
        private College college;
        private string fName;
        private string lName;
        private List<StudentGroup> groups = new List<StudentGroup>();

        /*Tasks are stored in the queue, because then a task is created for a student in for loop
         * it takes its place in this queue. Then, to evaluate each students task new for loop is created
         * and it goes through each student one more time, taking tasks from the queue (As a result
         * when first loop takes first student first tasks is created and put on the first position of the queue, 
         * etc. for other students' tasks. When all tasks are created program starts evaluation. To do it 
         * it takes each student from the first one and pops the tasks from the queue. So, FIFO allows to keep
         * pairs of student and task in order).
         */
        Queue<Task> tasks;

        public Teacher(College college, string fName, string lName)
        {
            this.college = college;
            this.fName = fName;
            this.lName = lName;
            tasks = new Queue<Task>();
            startSemester();
        }

        /*This method populate groups of students (Teacher has 3 groups, each of them contains 4 students)
         * All student in the group must be unique, therefore we used HashSet to store them.
         * Firstly, new HashSet of students is created for each group.
         * Then, these HashSets are filled by random students from college.
         * When we got all 4 students in the HashSet, we wrap this HashSet by the LinkedList 
         * (putting HashSet into the LinkedList constructor allows to copy all elements from HashSet to a new LinkedList)
         * to get the first argument of StudentGroup constructor. The second argument is given by 
         * createGroupDetails function (See comments under this function).
         * Then, new StudentGroup object is created and put into the groups List.
         */
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

        /*This method creates GroupDetails with random data.
         * Firstly, it takes list of all programs of the college.
         * Then, it takes two random numbers (one to choose program name from the list, another one - for semester number).
         * When we get program number (random number to choose program from the list),
         * we get all courses of this programs and put them into "courses" LinkedList.
         * After that, we create GroupDetails object via getGroupDetails function giving randomly chosen data to it.
         */
        public GroupDetails createGroupDetails()
        {
            Random rand = new Random();
            List<String> programs = new List<String>(college.getPrograms().Keys);
            int semNum = rand.Next(1, 5);
            int progNum = rand.Next(programs.Count);
            LinkedList<Course> courses = college.getPrograms()[programs[progNum]];
            return GroupDetails.getGroupDetails(semNum, courses, programs[progNum]);
        }

        /*This method simulates working of a teacher.
         * It goes though each group via outer for loop.
         * Then, it creates tasks via createTasksForGroup method for each student in each group.
         * After that, it goes into inner for loop to go through all courses of the group, and
         * finally it goes to the third loop ti evaluate each student of the group \
         * (It evaluates each student's taks for the first course, then it evaluates each student's task for the second course etc.).
         * This method allows to create tasks for all students in all groups and then evaluate them.
         */
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

        /*This function creates tasks for all student in the group.
         * Firstly, it takes list of courses of the group, 
         * then, according to this list, it goes through each course
         * creating new task for each student in the group.
         * When task is created it is put into the queue.
         */
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

        /*This finction takes student and his or her task and then evaluate this task.
         * We use TaskCheckerDecorator to use funstionality of a TaskChecker created according to the type of task.
         * When we got needed TaskChecker (MathTaskChecker for MathTask etc.) and placed it into the inner field of decorator
         * we call checkTask method of decorator which takes task and array of students answers. Students answer is randomly
         * picked from all variants of this task's answers (Which means that method just takes random answer from the range).
         * If student answer corresponds to the correct answer method returns true, else - it returns false.
         * After that program randomly calculate the srudent's score for this task based on the result of checkTask method.
         * If the result is true - tasks score will be the random number from 71 to 100. If the result is false - 
         * student's score will be from 0 to 70. Then updateOverallScore method is called to update overall score of given student.
         */
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
