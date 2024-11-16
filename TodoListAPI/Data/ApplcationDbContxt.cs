using TodoListAPI.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace TodoListAPI.Data
{
    public class ApplcationDbContxt : DbContext
    {
        public ApplcationDbContxt(DbContextOptions options): base(options) { }

        public DbSet<TodoModel> Todos { get; set; }
    }
}
