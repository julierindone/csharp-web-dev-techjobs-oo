using System;
using System.Collections.Generic;
using System.Text;

namespace TechJobsOO
{
    public abstract class JobField
    {
        public int Id { get; }

        private static int nextId = 1;

        public string Value { get; set; }

        public JobField()                       ///////constructor 
        {
            Id = nextId;
            nextId++;
        }

        public JobField(string value) : this()
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
