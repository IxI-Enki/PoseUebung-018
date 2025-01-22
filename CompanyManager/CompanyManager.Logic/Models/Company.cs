using CompanyManager.Logic.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyManager.Logic.Models
{
        internal class Company : ICompany
        {
                public string Name { get => throw new NotImplementedException( ); set => throw new NotImplementedException( ); }
                public string? Address { get => throw new NotImplementedException( ); set => throw new NotImplementedException( ); }

                public int Id => throw new NotImplementedException( );
        }
}
