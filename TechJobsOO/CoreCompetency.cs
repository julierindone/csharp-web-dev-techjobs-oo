using System;
namespace TechJobsOO
{
    public class CoreCompetency : JobField
    {
        private int id;
        private static int nextId = 1;

        // DONE - TODO: Change the fields to auto-implemented properties.
        public int Id { get; set; }
        public string Value { get; set; }

        public CoreCompetency()
        {
            id = nextId;
            nextId++;
        }

        public CoreCompetency(string value) : this()  
        {
            Value = value;                            
        }

        public override bool Equals(object obj)
        {
            return obj is CoreCompetency competency &&
                   id == competency.id;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(id);
        }

        public override string ToString()
        {
            return Value;                  ///////changed value to Value
        }
    }
  //}  
}
