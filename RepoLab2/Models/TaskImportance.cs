﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RepoLab2.Models
{
    public class TaskImportance
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<Taskul> Taskuri { get; set; }
    }
}