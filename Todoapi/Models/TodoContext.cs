using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Todoapi.Models
{
    public class TodoContext: DbContext
    {
        /*
         * Typically you create a class that derives from DbContext and contains 
         * DbSet<TEntity> properties for each entity in the model. 
         * If the DbSet<TEntity> properties have a public setter, 
         * they are automatically initialized when the instance of 
         * the derived context is created.
         * read more .. https://docs.microsoft.com/en-us/ef/core/api/microsoft.entityframeworkcore.dbcontext
         * */
        public TodoContext(DbContextOptions<TodoContext> options):base(options)
        {

        }

        //
        public DbSet<TodoItem> TodoItems { get; set; }
    }
}
