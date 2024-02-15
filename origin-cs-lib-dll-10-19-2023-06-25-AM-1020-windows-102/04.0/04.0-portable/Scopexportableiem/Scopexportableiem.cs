using Core;

namespace Core
{
    using System;

    [AttributeUsage(AttributeTargets.Method)]
    public partial class Scopexportableiem : Attribute
    {
        public Scopexportableiem()
        {
            return;
        }

        ~Scopexportableiem()
        {
            return;
        }
    }
}
