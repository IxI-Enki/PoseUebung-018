using CompanyManager.Logic.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
namespace CompanyManager.Logic.DataContext
{
        public class DbSet<T> : List<T> where T : IdentityObject
        {

                public void Added( T entity )
                {
                        int maxId = 1;

                        if(this.Count > 0)
                                maxId = this.Max( e => e.Id ) + 1;
                        entity.Id = maxId;
                        base.Add( entity );
                }
        }
}
*/