using System;
using Library.DataAccess.Entities.Enums;

namespace Library.DataAccess.Entities
{
    public abstract class Account
    {
        public Guid Id { get; set; }
        public AccountStatus Status { get; set; }
        public Person Person { get; set; }
    }
}