using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace MVVMApplication.Model
{
    public class PersonDB : Person
    {
        public PersonDB() : base("name=Person")
        {

        }

        public DbSet<Person> Person { get; set; }
    }
}