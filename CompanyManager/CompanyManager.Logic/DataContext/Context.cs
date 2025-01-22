using CompanyManager.Logic.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyManager.Logic.DataContext
{
        internal class Context : IContext
        {
                public void Dispose( )
                {
                        throw new NotImplementedException( );
                }

                public int SaveChanges( )
                {
                        throw new NotImplementedException( );
                }
        }
}
