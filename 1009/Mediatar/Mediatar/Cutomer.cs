using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Mediatar
{
    public abstract class Customer
    {
        public int CutomerID { get; }
        public string Name { get; }
        public int Renting { get; }
        public int Percentage { get; }

        protected Customer(int customerId, string name, int renting, int percentage)
        {
            CutomerID = customerId;
            Name = name;
            Renting = renting;
            Percentage = percentage;
        }
    }

    public class Student : Customer
    {
        public Student(int customerId, string name)
            : base(customerId, name, 3, 50) { }
    }

    public class Adult : Customer
    {
        public Adult(int customerId, string name)
            : base(customerId, name, 5, 100) { }
    }

    public class Elder : Customer
    {
        public Elder(int customerId, string name)
            : base(customerId, name, 5, 0) { }
    }
}
