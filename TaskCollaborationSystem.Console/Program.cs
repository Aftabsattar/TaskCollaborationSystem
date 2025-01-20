using System.ComponentModel.DataAnnotations;
using TaskCollaborationSystem;

var members = new List<Member>();
var tasks = new List<MemberTask>();

Console.WriteLine("Welcome to Task Collaboration System");

do
{
    // Display Menu
    Console.WriteLine("1. Add member");
    Console.WriteLine("2. Add task");
    Console.WriteLine("3. View all task");
    Console.WriteLine("4. Search for task");
    Console.WriteLine("5. Assign/Change Task Owner");
    Console.WriteLine("6. View Overdue Tasks");
    Console.WriteLine("7. View All Assigned Tasks");
    Console.WriteLine("8. Update Task Status");
    Console.WriteLine("9. Delete a Task");
    Console.WriteLine("10.Exit");

    // Input choice
    var choice = Console.ReadLine();
    Console.Clear();

    switch (choice)
    {
        case "1":
            {
                var member = new Member();
                member.InputAndPopulate();

                members.Add(member);

                Console.WriteLine($"{member.Name} Added Successfully!");
                PressToContinue();
                break;
            }
        case "2":
            {
                var task = new MemberTask();
                task.InputAndPopulate();

                tasks.Add(task);

                Console.WriteLine($"{task.Name} Added Successfully!");
                PressToContinue();
                break;
            }
        case "3":
            {
                if(tasks.Count == 0)
                {
                    Console.WriteLine("Nothing to show!");
                    PressToContinue();
                    break;
                }

                foreach (var task in tasks)
                    task.Show();

                PressToContinue();
                break;
            }
        case "4":
            {
                Console.Write("Enter Task Name: ");
                var taskName = Console.ReadLine();

                var founded = tasks.Where(task => task.Name == taskName);
             
                if(founded == null)
                    Console.WriteLine("Not Found!");
                else
                {
                    foreach (var task in founded)
                        task.Show();
                }

                PressToContinue();
            }
            break;
        case "5":
            {
                Console.Write("Enter Member Name: ");
                var memberName = Console.ReadLine();

                var member = members.Find(member => member.Name == memberName);
                if(member == null)
                {
                    Console.WriteLine("Member not found!");
                    PressToContinue();
                    break;
                }

                Console.Write("Enter Task Name: ");
                var taskName = Console.ReadLine();

                var task = tasks.Find(task => task.Name == taskName);
                if(task == null)
                {
                    Console.WriteLine("Task not found!");
                    PressToContinue();
                    break;
                }

                task.Assigne = member;
            }
            break;
        case "6":
            {
                var found  = tasks.FindAll(task => task.DueDate < DateTime.Now);

                found.ForEach(task =>
                {
                    task.Show();
                });
            }
            break;
        case "7":
            {
                var assignedTasks = tasks.FindAll(tasks => tasks.Assigne != null);
                assignedTasks.ForEach(task => task.ShowAssignment());
            }
            break;
        case "8":
            {
                // Task task name as input
                Console.Write("Enter Task Name: ");
                var taskName = Console.ReadLine();

                // Find the task having same name
                var task = tasks.Find(task => task.Name == taskName);
                if (task == null)
                {
                    Console.WriteLine("Task not found!");
                    PressToContinue();
                    break;
                }

                task.UpdateStatus();
            }
            break;
        case "9":
            {
                // Task task name as input
                Console.Write("Enter Task Name: ");
                var taskName = Console.ReadLine();

                // Find the task having same name
                var task = tasks.Find(task => task.Name == taskName);
                if (task == null)
                {
                    Console.WriteLine("Task not found!");
                    PressToContinue();
                    break;
                }

                // Remove
                tasks.Remove(task);
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

   
    Console.Clear();
} while (true);


void PressToContinue()
{
    Console.WriteLine("\nPress any key to continue...");
    Console.ReadKey();
}