﻿using CompanyManager.Logic.Contracts;

namespace CompanyManager.Logic.Entities
{
        public abstract class EntityObject : IIdentifiable
        {
                public int Id { get; set; }

                public void CopyProperties( IIdentifiable other )
                {
                        if(other == null) throw new ArgumentNullException( "other" );

                        Id = other.Id;
                }
        }
}
