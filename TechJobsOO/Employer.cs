using System;

namespace TechJobsOO
{
    public class Employer : JobField
    {
        /* public int Id { get; }                                ////remove these!
         private static int nextId = 1;
         public string Value { get; set; }*/



        public Employer(string value) : base(value)      //////constructor
        {
        }

        /*public override bool Equals(object obj)         ////// method    ////////// remove
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
        }*/
    }
}
