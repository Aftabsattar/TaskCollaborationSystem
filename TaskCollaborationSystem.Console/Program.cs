using TaskCollaborationSystem.ConsoleApp.Entities;
using TaskCollaborationSystem.ConsoleApp.Managers;
using TaskCollaborationSystem.ConsoleApp.Managers.Interface;

IManager taskManager = new Manager<MemberTask>();
IManager memberManager = new Manager<Member>();
IManager manager = taskManager;

Console.WriteLine("Welcome to Task Collaboration System");

do
{
    Console.WriteLine("1. Add");
    Console.WriteLine("2. Delete");
    Console.WriteLine("3. View");
    Console.WriteLine("4. Update");
    Console.WriteLine("5. Exit");

    Console.Write("Enter your choice: ");
    var choice = Console.ReadLine();
    Console.Clear();

    switch (choice)
    {
        case "1":
            {
                ChooseManager();
                manager.Add();
                break;
            }
        case "2":
            {
                ChooseManager();
                manager.Remove();
                break;
            }
        case "3":
            {

                ChooseManager();
                manager.View();
                break;
            }
        case "4":
            {
                ChooseManager();
                manager.Update();
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

int ChooseEntity()
{
    Console.WriteLine("1. Member");
    Console.WriteLine("2. Task");
    Console.Write("Choose from above > ");
    return Convert.ToInt32(Console.ReadLine());
}

void ChooseManager()
{
    switch (ChooseEntity())
    {
        case 1:
            manager = memberManager;
            break;
        case 2:
            manager = taskManager;
            break;
        default:
            Console.WriteLine("Invalid choice.");
            break;
    }
}