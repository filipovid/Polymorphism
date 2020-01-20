using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinedraftApp.Models
{
    public abstract class Identificator
    {
        public string Id { get; }

        public Identificator(string id)
        {
            Id = id;
        }
    }
}
