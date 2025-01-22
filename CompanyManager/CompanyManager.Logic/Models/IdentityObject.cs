using CompanyManager.Logic.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyManager.Logic.Models
{
        public abstract partial class IdentityObject : IIdentifiable
        {
                public int Id { get; set; }
        }
}
