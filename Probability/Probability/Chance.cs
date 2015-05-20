using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Probability
{
    public class Chance
    {
        private decimal value;

        public Chance(decimal value)
        {
            this.value = value;
        }

        public Chance Not()
        {
            return new Chance(1 - this.value);
        }

        public Chance And(Chance anotherChance)
        {
            return new Chance(this.value * anotherChance.value);
        }

        public Chance Or(Chance anotherChance)
        {
            return new Chance(this.value + anotherChance.value * this.Not().value);
        }

        public override bool Equals(object obj)
        {
            if(obj == null)
            {
                return false;
            }

            if (this.GetType() != obj.GetType())
            {
                return false;
            }

            Chance chance = (Chance)obj;

            return (this.value == chance.value);
        }

        public override int GetHashCode()
        {
            return 31 * (int)value * base.GetHashCode();
        }

        public override string ToString()
        {
            return string.Format("Chance[{0}]", value);
        }
    }
}
