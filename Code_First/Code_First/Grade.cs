﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Code_First
{
    public class Grade
    {
        public int GradeID { get; set; }
        public string GradeName { get; set; }
        public string Section { get; set; }
        public ICollection<Student> Students { get; set; }
    }
}
