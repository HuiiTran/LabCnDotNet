﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai1
{
    public class NhanVienSanXuat : INhanVien
    {
        public string Name { get; set; }
        public string DateOfBirth { get; set; }
        public int Salary { get; set; }
        public int BasicSalary { get; set; }
        public int ProductQuantity { get; set; }
        public int CalSalary()
        {
            return BasicSalary * ProductQuantity;
        }
    }
}