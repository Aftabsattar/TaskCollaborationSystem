
namespace TaskCollaborationSystem
{

    class AddTask
    {
        public AddMember Assigne { get; set; }
        public string? TaskName { get; set; }
        public string? TaskDescription { get; set; }
        public DateTime TaskDueDate { get; set; }
        public string? TaskStatus { get; set; }
        public void Task()
        {
            Console.WriteLine("Enter Task Name:");
            TaskName = Console.ReadLine();
            Console.WriteLine("Enter Task Description:");
            TaskDescription = Console.ReadLine();
            Console.WriteLine("Enter Task Due Date:");
            TaskDueDate = Convert.ToDateTime(Console.ReadLine());
            Console.WriteLine("Enter Task Status:");
            TaskStatus = Console.ReadLine();
            Console.WriteLine("Task added successfully.");
        }

        // show task
        public void show()
        {
            Console.WriteLine($"Task Name: {TaskName} ");
            Console.WriteLine($"Task Description: {TaskDescription}");
            Console.WriteLine($"Task Due Date:{TaskDueDate} ");
            Console.WriteLine($"Task Status:{TaskStatus} ");
        }
        // assign task
        public void AssignTask()
        {
            
            Console.WriteLine("Enter Member Name to Assign Task:");
            string? memberName = Console.ReadLine();
            if (Assigne.MemberName==memberName)
            {
                Assigne = new AddMember ();
                Console.WriteLine("Task assigned successfully.");
            }
            else
            {
                Console.WriteLine("Invalid member name.");
            }
            Console.WriteLine(Assigne.MemberName);
        }

        // view member task
        public void ViewMemberTask()
        {
            if (Assigne == null)
            {
                Console.WriteLine("No member assigned to this task.");
                return;
            }
            Console.WriteLine("Assigned Member Task");
            Console.WriteLine($"Task Assigned to: {Assigne.MemberName}");
            Console.WriteLine($"Task Name: {TaskName}");
            Console.WriteLine($"Task Description: {TaskDescription}");
            Console.WriteLine($"Task Status: {TaskStatus}");
            Console.WriteLine($"Task Due Date: {TaskDueDate}");
        }
    }
}
