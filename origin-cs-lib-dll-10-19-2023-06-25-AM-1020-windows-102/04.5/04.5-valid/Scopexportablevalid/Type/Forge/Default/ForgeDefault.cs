using Core;

namespace Core
{
    using System;

    using System.Collections;

    public partial struct Scopexportablevalid
    {
        public static Scopexportablevalid ForgeDefault(Scopexportableformbuildsolid[] array_SCOPEXPORTABLEFORMBUILDSOLID)
        {
            Scopexportablevalid scopexportablevalidResult = default;

            Scopexportablevalid scopexportablevalid;

            scopexportablevalid = new Scopexportablevalid();

            scopexportablevalid.ScopexportableformbuildsolidArray = array_SCOPEXPORTABLEFORMBUILDSOLID;

            var deflect = new IEnumerable[5];

            deflect[0] = Scopexportabledictionary.ScopexportabledictionaryDictionaryEmptyDispenser<Scopexportableformbuildsolid, Boolean>();

            deflect[1] = Scopexportabledictionary.ScopexportabledictionaryDictionaryEmptyDispenser<Scopexportableformhierarchynumeratesolid, Boolean>();

            deflect[2] = Scopexportabledictionary.ScopexportabledictionaryDictionaryEmptyDispenser<Scopexportableformhierarchynumeratesolid, Int32>();

            deflect[3] = Scopexportabledictionary.ScopexportabledictionaryDictionaryEmptyDispenser<Scopexportableformhierarchynumeratesolid, Int32>();

            deflect[4] = Scopexportabledictionary.ScopexportabledictionaryDictionaryEmptyDispenser<Scopexportableformhierarchynumeratesolid, String>();

            foreach (Scopexportableformbuildsolid value_SCOPEXPORTABLEFORMBUILDSOLID in array_SCOPEXPORTABLEFORMBUILDSOLID)
            {
                Scopexportabledictionary.ScopexportabledictionaryDictionaryCastDispenser<Scopexportableformbuildsolid, Boolean>(deflect[0]).Add(value_SCOPEXPORTABLEFORMBUILDSOLID, false);

                continue;
            }

            foreach (Scopexportableformbuildsolid value_SCOPEXPORTABLEFORMBUILDSOLID in array_SCOPEXPORTABLEFORMBUILDSOLID)
            {
                foreach (Scopexportableformhierarchynumeratesolid scopexportablehierarchynumeratesolid in value_SCOPEXPORTABLEFORMBUILDSOLID.ScopexportableformhierarchynumeratesolidNonParentArray)
                {
                    Scopexportabledictionary.ScopexportabledictionaryDictionaryCastDispenser<Scopexportableformhierarchynumeratesolid, Boolean>(deflect[1]).Add(scopexportablehierarchynumeratesolid, false);
                    
                    continue;
                }

                continue;
            }

            foreach (Scopexportableformbuildsolid value_SCOPEXPORTABLEFORMBUILDSOLID in array_SCOPEXPORTABLEFORMBUILDSOLID)
            {
                foreach (Scopexportableformhierarchynumeratesolid scopexportablehierarchynumeratesolid in value_SCOPEXPORTABLEFORMBUILDSOLID.ScopexportableformhierarchynumeratesolidNonParentArray)
                {
                    Scopexportabledictionary.ScopexportabledictionaryDictionaryCastDispenser<Scopexportableformhierarchynumeratesolid, Int32>(deflect[2]).Add(scopexportablehierarchynumeratesolid, -1);

                    continue;
                }

                continue;
            }

            foreach (Scopexportableformbuildsolid value_SCOPEXPORTABLEFORMBUILDSOLID in array_SCOPEXPORTABLEFORMBUILDSOLID)
            {
                foreach (Scopexportableformhierarchynumeratesolid scopexportablehierarchynumeratesolid in value_SCOPEXPORTABLEFORMBUILDSOLID.ScopexportableformhierarchynumeratesolidNonParentArray)
                {
                    Scopexportabledictionary.ScopexportabledictionaryDictionaryCastDispenser<Scopexportableformhierarchynumeratesolid, Int32>(deflect[3]).Add(scopexportablehierarchynumeratesolid, -1);

                    continue;
                }

                continue;
            }

            foreach (Scopexportableformbuildsolid value_SCOPEXPORTABLEFORMBUILDSOLID in array_SCOPEXPORTABLEFORMBUILDSOLID)
            {
                foreach (Scopexportableformhierarchynumeratesolid scopexportablehierarchynumeratesolid in value_SCOPEXPORTABLEFORMBUILDSOLID.ScopexportableformhierarchynumeratesolidNonParentArray)
                {
                    Scopexportabledictionary.ScopexportabledictionaryDictionaryCastDispenser<Scopexportableformhierarchynumeratesolid, String>(deflect[4]).Add(scopexportablehierarchynumeratesolid, String.Empty);

                    continue;
                }

                continue;
            }

            Scopexportablevalidenum scopexportablevalidenum;

            scopexportablevalidenum = new Scopexportablevalidenum();

            scopexportablevalidenum.Dictionary = Scopexportabledictionary.ScopexportabledictionaryDictionaryCastDispenser<Scopexportableformbuildsolid, Boolean>(deflect[0]);

            Scopexportablevalidnumerate scopexportablevalidnumerate;

            scopexportablevalidnumerate = new Scopexportablevalidnumerate();

            scopexportablevalidnumerate.Dictionary = Scopexportabledictionary.ScopexportabledictionaryDictionaryCastDispenser<Scopexportableformhierarchynumeratesolid, Boolean>(deflect[1]);

            Scopexportablevalidnumeratestart Scopexportablevalidnumeratestart;

            Scopexportablevalidnumeratestart = new Scopexportablevalidnumeratestart();

            Scopexportablevalidnumeratestart.Dictionary = Scopexportabledictionary.ScopexportabledictionaryDictionaryCastDispenser<Scopexportableformhierarchynumeratesolid, Int32>(deflect[2]);

            Scopexportablevalidnumerateend scopexportablevalidnumerateend;

            scopexportablevalidnumerateend = new Scopexportablevalidnumerateend();

            scopexportablevalidnumerateend.Dictionary = Scopexportabledictionary.ScopexportabledictionaryDictionaryCastDispenser<Scopexportableformhierarchynumeratesolid, Int32>(deflect[3]);

            Scopexportablevalidnumeratestring scopexportablevalidnumeratestring;

            scopexportablevalidnumeratestring = new Scopexportablevalidnumeratestring();

            scopexportablevalidnumeratestring.Dictionary = Scopexportabledictionary.ScopexportabledictionaryDictionaryCastDispenser<Scopexportableformhierarchynumeratesolid, String>(deflect[4]);

            scopexportablevalid.Scopexportablevalidenum = scopexportablevalidenum;

            scopexportablevalid.Scopexportablevalidnumerate = scopexportablevalidnumerate;

            scopexportablevalid.Scopexportablevalidnumeratestart = Scopexportablevalidnumeratestart;

            scopexportablevalid.Scopexportablevalidnumerateend = scopexportablevalidnumerateend;

            scopexportablevalid.Scopexportablevalidnumeratestring = scopexportablevalidnumeratestring;

            scopexportablevalidResult = scopexportablevalid;

            return scopexportablevalidResult;
        }
    }
}
