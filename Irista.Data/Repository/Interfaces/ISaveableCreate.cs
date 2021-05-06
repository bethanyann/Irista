using System;
using System.Collections.Generic;
using System.Text;

namespace Irista.Data.Repository.Interfaces
{
    public interface ISaveableCreate<TKey>
    {
        //points to primary key in table
        TKey Id { get; set; }
        //always in UTC
        DateTime DateCreatedUtc { get; set; }
    }
}
