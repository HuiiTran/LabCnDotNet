using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai2
{
    public class CongNhan : IObject
    {
        public string Name { get; set; }
        public string DateOfBirth { get; set; }
        public string Address { get; set; }
        public string Gender { get; set; }

        public string WorkAddress { get; set; }
        public string Salary {  get; set; }
    }
}
