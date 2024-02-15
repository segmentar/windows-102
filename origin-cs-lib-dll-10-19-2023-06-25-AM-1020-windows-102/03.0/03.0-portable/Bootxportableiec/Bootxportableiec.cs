using Core;

namespace Core
{
    using System;

    [AttributeUsage(AttributeTargets.All & ~AttributeTargets.Method)]
    public partial class Bootxportableiec : Attribute
    {
        public Bootxportableiec()
        {
            return;
        }

        ~Bootxportableiec()
        {
            return;
        }
    }
}
