using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace RepoLab2.Models.DataContext
{
    public class TaskuriDbContext : DbContext
    {
        public TaskuriDbContext(DbContextOptions<TaskuriDbContext> options) : base(options)
        {
        }

        public DbSet<Taskul> Taskuri { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Status> Statuses { get; set; }
        public DbSet<TaskImportance> TasksImportance { get; set; }
    }
}
