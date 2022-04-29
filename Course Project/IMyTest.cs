using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course_Project
{
    public interface IMyTest
    {
        public bool IsOne(object number);
        public int GetNumber();
        public int GetNumberOne() => 1;
        public int GetNumberTwo() => 2;
        public void Event(string info);
        public string CalculateBuzz(int number);
        public int RegisterStack(int number);
        public string Value { get; set; }
        public event EventHandler<Guid> Triggered;
    }
}
