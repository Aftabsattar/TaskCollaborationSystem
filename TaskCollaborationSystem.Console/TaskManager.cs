namespace TaskCollaborationSystem
{

    class TaskManager
    {
        private List<Member> members = new();
        private List<MemberTask> tasks = new();

        public void Add(string? input)
        {
            switch (input)
            {
                case "Member":
                    var member = new Member();
                    member.InputAndPopulate();
                    members.Add(member);
                    Console.WriteLine($"{member.Name} added successfully!");
                    PressToContinue();
                    break;

                case "Task":
                    var task = new MemberTask();
                    task.InputAndPopulate();
                    tasks.Add(task);
                    Console.WriteLine($"{task.Name} added successfully!");
                    PressToContinue();
                    break;
                   
                default:
                    Console.WriteLine("Invalid choice. Please enter 'Member' or 'Task'.");
                    break;
            }
        }
        public void Remove(string? input)
        {
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
        }
            public void Update(string? input)
            {
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

            public void View(string? input)
            {
                switch (input)
                {
                    case "Member":
                        if (members.Count == 0)
                        {
                            Console.WriteLine("No members found!");
                            PressToContinue();
                            break;
                        }
                        foreach (var member in members)
                            member.Show();
                        PressToContinue();
                        break;
                    case "Task":
                        if (tasks.Count == 0)
                        {
                            Console.WriteLine("No tasks found!");
                            PressToContinue();
                            break;
                        }
                        foreach (var task in tasks)
                            task.Show();
                        PressToContinue();
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please enter 'Member' or 'Task'.");
                        break;
                }
            }
            void PressToContinue()
            {
                Console.WriteLine("\nPress any key to continue...");
                Console.ReadKey();
            }
        }
    }

   