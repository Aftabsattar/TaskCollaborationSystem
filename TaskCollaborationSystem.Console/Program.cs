using TaskCollaborationSystem;
List<AddMember> newMember = new List<AddMember>();
List<AddTask> newTask = new List<AddTask>();
AddTask Task;
do
{ 
Console.WriteLine("Welcome to Task Collaboration System");
Console.WriteLine("1.Add member");
Console.WriteLine("2.Add task");
Console.WriteLine("3.View all task");
Console.WriteLine("4.search for task");
Console.WriteLine("5.Assign/Change Task Owner");
Console.WriteLine("6.View Overdue Tasks");
Console.WriteLine("7.view member task");
Console.WriteLine("8.Update Task Statu");
Console.WriteLine("9.Delete a Task");
Console.WriteLine("10.Exit");
   string? choice = Console.ReadLine();
switch (choice)
{
    case "1":
        {
            AddMember Member = new AddMember();
            Member.AddNewMember();
            newMember.Add(Member);
                break;
        }
    case "2":
        {
           Task = new AddTask();
             Task.Task();
            newTask.Add(Task);
            break;
        }
        case "3":
            {
                foreach (var T in newTask)
                {
                    T.show();
                }
                break;
            }
        case "4":
            {
                Task = new AddTask();
                Console.WriteLine("Enter Task Name:");
                string? taskName = Console.ReadLine();
                foreach (var task in newTask)
                {
                    if (task.TaskName == taskName)
                    {
                        task.show();
                    }
                }
            }
            break;
        case "5":
            {
                Task = new AddTask();
                Task.AssignTask();
            }
            break;
        case "6":
            {
                AddTask nT = new AddTask();
                foreach (var T in newTask)
                {
                    if (T.TaskDueDate < DateTime.Now)
                    {
                       T.show();
                    }
                }
            }
            break;
        case "7":
            {
                Task = new AddTask();
                Task.show();
            }
            break;
        case "8":
            {
                Task = new AddTask();
                Console.WriteLine("Enter Task Name");
                string? TaskName = Console.ReadLine();
                foreach (var task in newTask)
                {
                    if (task.TaskName == TaskName)
                    {
                        Console.WriteLine("Enter Task Status => Pending,InProgress,Completed");
                        task.TaskStatus = Console.ReadLine();
                        Console.WriteLine("Task status updated successfully.");
                    }
                }
            }
            break;
        case "9":
            {
                Task = new AddTask();
                Console.WriteLine("Enter Task Name:");
                string? taskName = Console.ReadLine();
                foreach(var task in newTask)
                {
                    if (task.TaskName == taskName)
                    {
                        newTask.Remove(task);
                        Console.WriteLine("Task deleted successfully.");
                        break;
                    }
                }
            }
            break;
        
        case "10":
            {
                Environment.Exit(0);
                break;
            }
        default:
        {
            Console.WriteLine("Invalid choice.");
            break;
        }
}
    Console.WriteLine("Do you want to continue? (Y/N)");
    string? response = Console.ReadLine();
    if (response.ToUpper() == "N")
    {
        break;
    }
    Console.WriteLine();
} while (true);
