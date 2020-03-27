using System;
using System.Linq;
using ValueObjectPoc.OwnedEntities.Extensions;
using ValueObjectPoc.OwnedEntities.ValueObjects;

namespace ValueObjectPoc.OwnedEntities
{
    public static class Program
    {
        static void Main(string[] args)
        {
            using (var context = new OwnedEntityContext())
            {
                context.Database.EnsureDeleted();
                context.Database.EnsureCreated();

                context.Add(new Customer
                {
                    Ssn = new Ssn("123456789"),
                });

                context.SaveChanges();
            }

            using (var context = new OwnedEntityContext())
            {
                var customer = context.Customers.First();

                Console.WriteLine($"First pending order will ship to: {customer.Ssn}");

                ///Try to use %LIKE% to find customer by SSN
                var customers = context.Customers.Where(q => q.Ssn.Contains("123456789"));
                var sql = customers.ToSql();

                //Write out the SQL to see how/if it is processed
                Console.WriteLine(sql); 
            }
        }
    }
}