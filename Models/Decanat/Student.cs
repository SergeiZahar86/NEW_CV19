using NEW_CV19.Models.Interfaces;
using System;

namespace NEW_CV19.Models.Decanat
{
    internal class Student : IEntity
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Surname { get; set; }

        public string Patronymic { get; set; }

        public DateTime Birthday { get; set; }

        public double Rating { get; set; }

        public string Description { get; set; }
    }
}
