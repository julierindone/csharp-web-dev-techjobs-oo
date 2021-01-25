using System;
namespace TechJobsOO
{
    public class Employer
    {
        public int Id { get; }
        private static int nextId = 1;
        public string Value { get; set; }

        public Employer()                           ///////1st constructor
        {
            Id = nextId;
            nextId++;
        }

        public Employer(string value) : this()      ////////also a constructor
        {
            Value = value;
        }

        public override bool Equals(object obj)         ////// method
        {
            return obj is Employer employer &&
                   Id == employer.Id;
        }

        public override int GetHashCode()               ////// method
        {
            return HashCode.Combine(Id);
        }

        public override string ToString()               //////method
        {
            return Value;
        }
    }
}
