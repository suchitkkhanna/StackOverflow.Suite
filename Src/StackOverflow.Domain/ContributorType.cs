using System;

namespace StackOverflow.Domain
{
    public class ContributorType
    {

        public ContributorType(int id, string name, string description)
        {
            Id = id;
            Name = name;
            Description = description;
        }

        public int Id { get; }

        public string Name { get; }

        public string Description { get; }

        public override string ToString() => $"{Id} : {Name}";
    }
}