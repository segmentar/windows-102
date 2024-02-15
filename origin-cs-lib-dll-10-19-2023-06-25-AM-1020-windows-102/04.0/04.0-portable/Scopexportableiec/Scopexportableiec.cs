using Core;

namespace Core
{
    using System;

    [AttributeUsage(AttributeTargets.All & ~AttributeTargets.Method)]
    public partial class Scopexportableiec : Attribute
    {
        public Scopexportableiec()
        {
            return;
        }

        ~Scopexportableiec()
        {
            return;
        }
    }
}
