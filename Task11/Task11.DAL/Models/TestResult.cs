using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task11.DAL.Models
{
    public class TestResult
    {
        public string TestName { get; set; }
        public string StudentName { get; set; }
        public byte Score { get; set; }
        public DateTime DatePassing { get; set; }
    }
}
