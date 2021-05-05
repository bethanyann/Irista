using Irista.Data.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Irista.Data.Entities
{
    public class BaseEntity : ISaveableCreate<string>
    {
        public string Id { get; set; }
        public DateTime DateCreatedUtc { get; set; }
    }
}
