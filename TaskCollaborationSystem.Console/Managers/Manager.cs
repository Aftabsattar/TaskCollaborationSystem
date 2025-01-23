using TaskCollaborationSystem.ConsoleApp.Entities.Interface;
using TaskCollaborationSystem.ConsoleApp.Managers.Interface;

namespace TaskCollaborationSystem.ConsoleApp.Managers
{

    class Manager<EntityClass> : IManager
        where EntityClass : IEntity, new()
    {
        private List<EntityClass> list = new();

        public void Add()
        {
            var obj = new EntityClass();

            obj.InputAndPopulate();
            list.Add(obj);

            Console.WriteLine($"{obj.Name} added successfully!");
            PressToContinue();
        }

        public void Remove()
        {
            Console.Write("Enter Name: ");
            var objName = Console.ReadLine();
            var obj = list.Find(obj => obj.Name == objName);
            if (obj == null)
            {
                Console.WriteLine("object not found!");
                PressToContinue();
                return;
            }
            list.Remove(obj);
            Console.WriteLine($"{objName} Removed Successfully!");
            PressToContinue();
        }

        public void Update()
        {
            Console.Write("Enter Member Name: ");
            var objName = Console.ReadLine();
            var obj = list.Find(obj => obj.Name == objName);
            if (obj == null)
            {
                Console.WriteLine("Member not found!");
                PressToContinue();
                return;
            }
            obj.InputAndPopulate();
            Console.WriteLine($"{objName} Updated Successfully!");
            PressToContinue();
        }

        public void View()
        {
            if (list.Count == 0)
            {
                Console.WriteLine("No list found!");
                PressToContinue();
                return;
            }
            foreach (var obj in list)
                obj.Show();
            PressToContinue();

        }

        void PressToContinue()
        {
            Console.WriteLine("\nPress any key to continue...");
            Console.ReadKey();
        }
    }
}

