using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Damas.Domain.Shared
{
    public class EntityBase
    {
        public int Id { get; set; }

        public DateTime? Modified { get; set; }
        public DateTime? Created { get; set; }
    }
}
