
namespace TaskCollaborationSystem
{
    class Member
    {
        public string? Id { get; set; }
        public string? Name { get; set; }
        public string? Email { get; set; }
        
        public void InputAndPopulate()
        {
            Console.Write("Enter Member Id: ");
            Id = Console.ReadLine();

            Console.Write("Enter Member Name: ");
            Name = Console.ReadLine();

            Console.Write("Enter Email: ");
            Email = Console.ReadLine();
        }
        // create a method to show the member details
        public void Show()
        {
            Console.WriteLine($"Member Id: {Id} ");
            Console.WriteLine($"Member Name: {Name}");
            Console.WriteLine($"Email:{Email} \n");
        }
    }
}
