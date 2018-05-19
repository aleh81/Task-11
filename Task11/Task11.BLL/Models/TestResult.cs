using System;

namespace Task11.BLL.Models
{
    public class TestResult : IComparable
    {
        public string TestName { get; set; }
        public string StudentName { get; set; }
        public byte Score { get; set; }
        public DateTime DatePassing { get; set; }

        public int CompareTo(object obj)
        {
            return 0;
        }
    }
}
