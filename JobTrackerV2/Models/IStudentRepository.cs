﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JobTrackerV2.Models
{
    public interface IStudentRepository
    {
        Student GetStudent(int Id);
    }
}