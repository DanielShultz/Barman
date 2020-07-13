using System.Collections.Generic;

namespace Tourism
{
    public class Client
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string SecondName { get; set; }
        public string Surname { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }

        public string FullName
        {
            get
            {
                return Surname + " " + Name + " " + SecondName;
            }
        }

        public override string ToString()
        {
            return FullName;
        }

        public virtual ICollection<Order> Orders { get; set; }
    }
}