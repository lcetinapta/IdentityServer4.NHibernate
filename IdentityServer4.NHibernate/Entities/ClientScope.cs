﻿namespace IdentityServer4.NHibernate.Entities
{
    public class ClientScope : EntityBase<int>
    {
        public virtual string Scope { get; set; }
    }
}