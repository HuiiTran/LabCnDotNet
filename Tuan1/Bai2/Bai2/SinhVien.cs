﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai2
{
    public class SinhVien : IObject
    {
        public string Name { get; set; }
        public string DateOfBirth { get; set; }
        public string Address { get; set; }
        public string Gender { get; set; }

        public string Years { get; set; }
        public string Academic_Year { get; set; }
        public string School { get; set; }
        public string Field_of_Study { get; set; }

    }
}