using CompanyManager.Logic.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyManager.Logic.Models
{
        internal class Customer : ICustomer
        {
                private string _name = string.Empty;

                public int CompanyId
                {
                        get;
                        set;
                }
                public string Name
                {
                        get => _name;
                        set => _name = value;
                }
                public string Email
                {
                        get;
                        set;
                }

                public int Id { get; }
        }
}
