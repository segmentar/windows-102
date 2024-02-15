using Core;

namespace Core
{
    using System;

    using System.Collections;

    using System.Collections.Generic;
    using System.Collections.ObjectModel;

    public partial class ScopexportablemoduleBody
    {
        public partial class XNonuple
        {
            public static IList<Scopexportableformbodysolid> FunctionIjklmnSet(ScopexportableijklmnBodyUo_qrstV[] Ijklmn_ARRAY)
            {
                ICollection<Scopexportableformbodysolid> collectionResult = default;

                collectionResult = new Collection<Scopexportableformbodysolid>();

                foreach (ScopexportableijklmnBodyUo_qrstV Ijklmn_VALUE in Ijklmn_ARRAY)
                {
                    Scopexportableformbodysolid scopexportableformbodysolid;

                    scopexportableformbodysolid = new Scopexportableformbodysolid();

                    scopexportableformbodysolid.Object = Ijklmn_VALUE.Object;

                    scopexportableformbodysolid.Mid = Ijklmn_VALUE.Mid;

                    scopexportableformbodysolid.Form = Ijklmn_VALUE.Form;

                    scopexportableformbodysolid.Hierarchy = Ijklmn_VALUE.Hierarchy;

                    scopexportableformbodysolid.PortalArray = Ijklmn_VALUE.PortalArray;

                    scopexportableformbodysolid.BindArray = Ijklmn_VALUE.BindArray;

                    scopexportableformbodysolid.Body = Ijklmn_VALUE.Body;

                    scopexportableformbodysolid.BodyArray = Ijklmn_VALUE.BodyArray;

                    collectionResult.Add(scopexportableformbodysolid);

                    continue;
                }

                return new List<Scopexportableformbodysolid>(collectionResult);
            }
        }
    }
}
