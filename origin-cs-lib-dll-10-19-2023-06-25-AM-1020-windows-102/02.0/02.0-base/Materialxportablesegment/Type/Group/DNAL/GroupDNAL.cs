﻿using Core;

namespace Core
{
    using System;

    public partial class Materialxportablesegment
    {
        public static void GroupDNAL(Materialxportable value_MATERIALXPORTABLE, Object object_VALUE)
        {
            var reflect = (Materialxportablestringarraysafe)(value_MATERIALXPORTABLE.View.RouteIdentity as Object);

            var aoth = reflect.Value.Length;

            var zee = (aoth + 1);

            String[] stringArray;

            stringArray = new String[zee];

            reflect.Value.CopyTo(stringArray, MaterialxportablePolicy.MaterialxportableIndexPolicy);

            stringArray[aoth] = Materialxportablename.EntityNAL;

            Materialxportable materialxportable;

            materialxportable = new MaterialxportableSimple(stringArray).Result;

            materialxportable.ObjectIdentity = object_VALUE;

            ((Materialxportable[])value_MATERIALXPORTABLE.View.SegmentArrayObject)[3] = materialxportable;

            value_MATERIALXPORTABLE.View = materialxportable;

            return;
        }
    }
}
