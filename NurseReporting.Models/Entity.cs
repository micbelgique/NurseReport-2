using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NurseReporting.Models
{
    public abstract class Entity : IComparable<Entity>
    {
        private Guid _id;

        [Key]
        public Guid Id
        {
            get
            {
                if (_id == Guid.Empty)
                {
                    _id = Guid.NewGuid();
                }
                return _id;
            }
            set
            {
                _id = value;
            }
        }

        public int CompareTo(Entity other)
        {
            return this.Id.CompareTo(other.Id);
        }
    }
}
