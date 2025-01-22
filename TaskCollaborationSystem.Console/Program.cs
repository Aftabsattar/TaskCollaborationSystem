using TaskCollaborationSystem;

TaskManager taskManager = new TaskManager();
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
                Console.WriteLine("Member");
                Console.WriteLine("Task");
                var input = Console.ReadLine();
                taskManager.Add(input);
                break;
            }
        case "2":
            {
                Console.WriteLine("Member");
                Console.WriteLine("Task");
                var input = Console.ReadLine();
                taskManager.Remove(input);
            break;
            }
        case "3":
            {
                Console.WriteLine("Member");
                Console.WriteLine("Task");
                var input = Console.ReadLine();
                taskManager.View(input);
                break;
            }
        case "4":
            {
                Console.WriteLine("Member");
                Console.WriteLine("Task");
                var input = Console.ReadLine();
                taskManager.Update(input);
                break;
            }
           
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



