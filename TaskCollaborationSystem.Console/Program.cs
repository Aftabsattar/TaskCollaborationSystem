using TaskCollaborationSystem; 

var members = new List<Member>();
var tasks = new List<MemberTask>();

Console.WriteLine("Welcome to Task Collaboration System");

do
{
    Console.WriteLine("1. Add");
    Console.WriteLine("2. Delete");
    Console.WriteLine("3. View");
    Console.WriteLine("4. Update");
    Console.WriteLine("5.Exit");

    Console.Write("Enter your choice: ");
    var choice = Console.ReadLine();
    Console.Clear();

    switch (choice)
    {
        case "1":
            {
                Console.WriteLine("Enter 'Member' to add a member or 'Task' to add a task:");
                var input = Console.ReadLine();

                switch (input)
                {
                    case "Member":
                        var member = new Member();
                        member.InputAndPopulate();
                        members.Add(member);
                        Console.WriteLine($"{member.Name} added successfully!");
                        break;

                    case "Task":
                        var task = new MemberTask();
                        task.InputAndPopulate();
                        tasks.Add(task);
                        Console.WriteLine($"{task.Name} added successfully!");
                        break;

                    default:
                        Console.WriteLine("Invalid choice. Please enter 'Member' or 'Task'.");
                        break;
                }

                PressToContinue();
                break;
            }
        case "2":
            {
                Console.WriteLine("Enter 'Member' to add a member or 'Task' to add a task:");
                var input = Console.ReadLine();

                switch (input)
                {
                    case "Member":
                        Console.Write("Enter Member Name: ");
                        var memberName = Console.ReadLine();
                        var member = members.Find(member => member.Name == memberName);
                        if (member == null)
                        {
                            Console.WriteLine("Member not found!");
                            PressToContinue();
                            break;
                        }
                        members.Remove(member);
                        Console.WriteLine($"{memberName} Removed Successfully!");
                        PressToContinue();
                        break;

                    case "Task":
                        Console.Write("Enter Task Name: ");
                        var taskName = Console.ReadLine();
                        var task = tasks.Find(task => task.Name == taskName);
                        if (task == null)
                        {
                            Console.WriteLine("Task not found!");
                            PressToContinue();
                            break;
                        }

                        tasks.Remove(task);
                        Console.WriteLine($"{taskName} Removed Successfully!");
                        PressToContinue();
                        break;

                    default:
                        Console.WriteLine("Invalid choice. Please enter 'Member' or 'Task'.");
                        break;
                }
                break;
            }
        case "3":
            {
                Console.WriteLine("Enter 'Member' to add a member or 'Task' to add a task:");
                var input = Console.ReadLine();

                switch (input)
                {
                    case "Member":
                        if (members.Count == 0)
                        {
                            Console.WriteLine("Nothing to show!");
                            PressToContinue();
                            break;
                        }
                        else
                        {
                            foreach (var member in members)
                                member.Show();
                            PressToContinue();
                            break;
                        }
                    case "Task":
                    if (tasks.Count == 0)
                    {
                        Console.WriteLine("Nothing to show!");
                        PressToContinue();
                        break;
                    }
                    else
                    {
                        foreach (var task in tasks)
                            task.Show();
                        PressToContinue();
                        break;
                    }
                default:
                        Console.WriteLine("Invalid choice. Please enter 'Member' or 'Task'.");
                        break;
                }
                break;
            }
        case "4":
            {
                Console.WriteLine("Enter \n'Member' to add a member or 'Task' to add a task:");
                var input = Console.ReadLine();

                switch (input)
                {
                    case "Member":
                        Console.Write("Enter Member Name: ");
                        var memberName = Console.ReadLine();
                        var member = members.Find(member => member.Name == memberName);
                        if (member == null)
                        {
                            Console.WriteLine("Member not found!");
                            PressToContinue();
                            break;
                        }
                        member.InputAndPopulate();
                        Console.WriteLine($"{memberName} Updated Successfully!");
                        PressToContinue();
                        break;

                    case "Task":
                        Console.Write("Enter Task Name: ");
                        var taskName = Console.ReadLine();
                        var task = tasks.Find(task => task.Name == taskName);
                        if (task == null)
                        {
                            Console.WriteLine("Task not found!");
                            PressToContinue();
                            break;
                        }
                        task.InputAndPopulate();
                        Console.WriteLine($"{taskName} Updated Successfully!");
                        PressToContinue();
                        break;

                    default:
                        Console.WriteLine("Invalid choice. Please enter 'Member' or 'Task'.");
                        break;
                }
            }
            break;
        case "5":
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
    Console.Clear();
} while (true);


void PressToContinue()
{
    Console.WriteLine("\nPress any key to continue...");
    Console.ReadKey();
}
