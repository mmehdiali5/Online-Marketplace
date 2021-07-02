using Microsoft.AspNet.OData;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shopping_App.Models
{
    public class DBHelper
    {
        static SHOPPING_APP_DBMDFContext context = new SHOPPING_APP_DBMDFContext();

        static public List<T> Get<T, U>(U Id, string propertyName = "Id") where T : Table
        {
            DbSet<T> table = (DbSet<T>)context.GetType().GetProperty(typeof(T).Name + "Table").GetValue(context);

            // GetAll Check
            if (Id.Equals(0) || Id.Equals(null))
            {
                return table.ToList();
            }

            bool myPredicate(T item)
            {
                Type type = typeof(T);
                U itemId = (U)type.GetProperty(propertyName).GetValue(item);
                return itemId.Equals(Id);
            }

            return table.ToList().FindAll(myPredicate);
        }

        static public async Task<int> Add<T>(T item) where T : Table
        {
            DbSet<T> table = (DbSet<T>)context.GetType().GetProperty(typeof(T).Name + "Table").GetValue(context);
            table.Add(item);

            await context.SaveChangesAsync();

            return table.OrderBy(u => u.Id).Last().Id;
        }

        static public async Task Patch<T>(int Id, Delta<T> item) where T : Table
        {
            DbSet<T> table = (DbSet<T>)context.GetType().GetProperty(typeof(T).Name + "Table").GetValue(context);

            var entity = await table.FindAsync(Id);
            item.Patch(entity);

            await context.SaveChangesAsync();
        }

        static public async Task Update<T>(int Id, T item) where T : Table
        {
            DbSet<T> table = (DbSet<T>)context.GetType().GetProperty(typeof(T).Name + "Table").GetValue(context);

            T tmp = table.First(add => add.Id.Equals(Id));

            var properties = tmp.GetType().GetProperties();
            var type = tmp.GetType();

            for (int i = 0; i < properties.Length; ++i)
            {
                string propertyName = properties[i].Name;
                var value = type.GetProperty(propertyName).GetValue(item);
                type.GetProperty(propertyName).SetValue(tmp, value);
            }

            await context.SaveChangesAsync();
        }

        static public async Task Delete<T>(int Id, string propertyName = "Id") where T : Table
        {
            DbSet<T> table = (DbSet<T>)context.GetType().GetProperty(typeof(T).Name + "Table").GetValue(context);

            bool myPredicate(T item)
            {
                Type type = typeof(T);
                int itemId = (int)type.GetProperty(propertyName).GetValue(item);
                return itemId.Equals(Id);
            }

            context.Remove(table.First(myPredicate));

            await context.SaveChangesAsync();
        }
    }
}
