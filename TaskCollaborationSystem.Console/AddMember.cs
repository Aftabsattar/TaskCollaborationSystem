
namespace TaskCollaborationSystem
{

    class AddMember
    {
        public string? MemberID { get; set; }
        public string? MemberName { get; set; }
        public string? Email { get; set; }
        public void Add()
        {
            Console.Write("Enter Member ID:");
            MemberID = Console.ReadLine();
            Console.Write("Enter Member Name:");
            MemberName = Console.ReadLine();
            Console.Write("Enter Email:");
            Email = Console.ReadLine();
        }
        List<AddMember> newMember = new List<AddMember>();
        public void AddNewMember()
        {
            AddMember member = new AddMember();
            member.Add();
            newMember.Add(member);
            Console.WriteLine("Member added successfully.");
        }
    }
}
