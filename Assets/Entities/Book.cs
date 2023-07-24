using System;

namespace Entities
{
    [Serializable]
    public class Book
    {
        public int Id;
        public string Name;
        public string Description;

        public Book (int id, string name, string description)
        {
            Id = id;
            Name = name;
            Description = description;
        }
    }
}