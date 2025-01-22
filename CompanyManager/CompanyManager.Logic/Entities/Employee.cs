using CompanyManager.Logic.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyManager.Logic.Entities
{
        internal class Employee : IEmployee
        {
                public int CompanyId { get => throw new NotImplementedException( ); set => throw new NotImplementedException( ); }
                public string FirstName { get => throw new NotImplementedException( ); set => throw new NotImplementedException( ); }
                public string LastName { get => throw new NotImplementedException( ); set => throw new NotImplementedException( ); }
                public string Email { get => throw new NotImplementedException( ); set => throw new NotImplementedException( ); }

                public int Id => throw new NotImplementedException( );
        }
}
