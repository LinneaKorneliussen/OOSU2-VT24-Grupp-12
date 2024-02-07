using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatientDL
{
    public class Repository<T>
        where T : class
    {
        internal PatientContext context;
        internal DbSet<T> dbSet;


        public Repository(PatientContext context)
        {
            this.context = context;
            dbSet = context.Set<T>();
        }

        /// <summary>
        /// Add a new entity to the Table.
        /// </summary>
        /// <param name="entity"></param>
        public void Add(T entity)
        {
            dbSet.Add(entity);
        }
        /// <summary>
        /// Remove an entity from the Table.
        /// </summary>
        /// <param name="entity"></param>
        /// <returns>true if removed and false otherwise.</returns>
        public bool Remove(T entity)
        {
            dbSet.Remove(entity);
            return true;    
        }
        /// <summary>
        /// Find a set of entities that match a predicate.
        /// </summary>
        /// <param name="predicate"></param>
        /// <returns></returns>
        public IEnumerable<T> Find(Func<T, bool> predicate)
        {
            return dbSet.Where(predicate);
        }
        /// <summary>
        /// Find the first entity that match a predicate.
        /// </summary>
        /// <param name="predicate"></param>
        /// <returns></returns>
        public T FirstOrDefault(Func<T, bool> predicate)
        {
            return dbSet.FirstOrDefault(predicate);
        }
        /// <summary>
        /// Is this repository empty?
        /// </summary>
        /// <returns>true is it is empty, false otherwise.</returns>
        public bool IsEmpty()
        {
            return !context.Set<T>().Any();
        }

        /// <summary>
        /// Count the entities in the Table.
        /// </summary>
        /// <returns>the number of entities.</returns>
        /// 

        public int Count()
        {
            return dbSet.Count();
        }

        //internal Repository()
        //{
        //    if (table == null)
        //    {
        //        table = new List<T>();
        //    }
        //}
        // This is a bit strange but I don't want multiple lists of the class T.
        // NOTE: This is very bad if you use multiple threads.
        private static IList<T> table;

        public IEnumerable<T> GetAll()
        {
            return dbSet;
        }

    }
}
