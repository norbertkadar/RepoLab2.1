using System;
using System.Collections.Generic;
using System.Linq;

namespace RepoLab2.Models
{
    public class Status
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<Taskul> Taskuri { get; set; }
    }
}
