using AdvancedProject;

List<Student> students = new List<Student>();
List<Teacher> teachers = new List<Teacher>();

while (true)
{
    Console.WriteLine("Enter Your Command:");
    var command = Console.ReadLine();

    if (command == "Add")
    {
        Console.WriteLine("Add Your Student Or Teacher");
        var adding = Console.ReadLine();

        if (adding == "Student")
        {
            Console.WriteLine("Enter Your Student Name:");
            var studentname = Console.ReadLine();
            Console.WriteLine("Enter Your Student Family:");
            var studentfamily = Console.ReadLine();
            Console.WriteLine("Enter Your Student Score:");
            var studentscore = Convert.ToInt32(Console.ReadLine());
            //int[] scores = new int[studentscore];
            //int sum = 0;

            //for(int c = 0; c < scores.Length; c++)
            //{
            //    Console.WriteLine("Enter Your Score");
            //    var score = Convert.ToInt32(Console.ReadLine());
            //    scores[c] = score;
            //    sum += score;
            //}

            //var average = sum / scores.Length;

            var st = students.Where(s => s.Name == studentname && s.Family == studentfamily && s.Score == studentscore).FirstOrDefault();

            if (st == null)
            {
                students.Add(new Student() { Name = studentname, Family = studentfamily, Score = studentscore });
                ////foreach (var i in students)
                ////{
                ////    Console.WriteLine("Name:" + i.Name + "Family:" + i.Family + "Average Score:" + average);
                ////}
                Console.WriteLine("Student Added!");
            }
        }

        else if (adding == "Teacher")
        {
            Console.WriteLine("Enter Your Teacher Name:");
            var teachername = Console.ReadLine();
            Console.WriteLine("Enter Your Teacher Family:");
            var teacherfamily = Console.ReadLine();
            Console.WriteLine("Enter Your Teacher Lesson:");
            var teacherlesson = Console.ReadLine();

            var te = teachers.Where(t => t.Name == teachername && t.Family == teacherfamily && t.Course == teacherlesson).FirstOrDefault();

            if (te == null)
            {
                teachers.Add(new Teacher() { Name = teachername, Family = teacherfamily, Course = teacherlesson });
                //foreach (var i in teachers)
                //{
                //    Console.WriteLine("Name:" + i.Name + "Family:" + i.Family + "Course:" + i.Course);
                //}
            }
        }
    }

    else if (command == "GetScores")
    {
        var score = students.Sum(s => s.Score);
        Console.WriteLine(score/students.Count);
    }

    else if (command == "GetLesson")
    {
        var getlesson = teachers.Distinct().ToList();

        if (getlesson != null)
        {
            foreach (var l in getlesson)
            {
                Console.WriteLine(l.Course);
            }
        }

        //foreach (var i in getlesson)
        //{
        //    Console.WriteLine("Name:" + i.Name + "Family:" + i.Family + "Course:" + i.Course);
        //}
    }
}