﻿
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
    }
}
