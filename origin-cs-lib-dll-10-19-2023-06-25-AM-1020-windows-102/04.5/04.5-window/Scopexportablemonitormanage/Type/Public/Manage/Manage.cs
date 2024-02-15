using Core;

namespace Core
{
    using System;

    using System.Collections;

    public partial class Scopexportablemonitormanage
    {
        public static String Manage(String value_STRING)
        {
            String stringResult = default;

            stringResult = String.Empty;

            var inflect = new Object[1];

            var deflect = new IEnumerable[2];

            String stringValue;

            if (Object.Equals(Scopexportablemonitorframe.ReadOnlyCollection.Count, 0) is true)
            {
                stringValue = String.Empty;

                stringResult = stringValue;

                return stringResult;
            }
            else
                "false".ToString();

            deflect[0] = Scopexportablemagic.ScopexportablemagicArrayListDispenser(Scopexportablemonitorframe.ReadOnlyCollection);

            var weirdbug = ((ArrayList)deflect[0]).Count <= Scopexportablemonitorframe.Pointer;

            if (weirdbug)
            {
                Console.Out.WriteLine($"alert [{Scopexportablemonitorframe.ScopexportablemonitortransactionArray[Scopexportablemonitorframe.Pointer].Scopexportablemonitorframe}] [{((ArrayList)deflect[0]).Count}] [{Scopexportablemonitorframe.Pointer}] [{((ArrayList)deflect[0]).Count <= Scopexportablemonitorframe.Pointer}]");

                Scopexportablerestart.Restart();

                return stringResult;
            }

            inflect[0] = Scopexportablemagic.ScopexportablemagicArrayListDispenser(deflect[0])[Scopexportablemonitorframe.Pointer];

            var reflect = (Scopexportablemonitortransaction)(inflect[0]);

            switch (value_STRING)
            {
                case Scopexportablestoremonitor.EntityMonitorExpression:
                    stringValue = reflect.Scopexportablemonitorexpression.ToString();
                    break;

                case Scopexportablestoremonitor.EntityMonitorParameter:
                    stringValue = reflect.Scopexportablemonitorparameter.ToString();
                    break;

                case Scopexportablestoremonitor.EntityMonitorState:
                    stringValue = reflect.Scopexportablemonitorstate.ToString();
                    break;

                case Scopexportablestoremonitor.EntityMonitorFrame:
                    stringValue = reflect.Scopexportablemonitorframe.ToString();
                    break;

                case Scopexportablestoremonitor.EntityMonitorFilearray:
                    stringValue = reflect.Scopexportablemonitorfilearray.ToString();
                    break;

                case Scopexportablestoremonitor.EntityMonitorValid:
                    stringValue = reflect.Scopexportablemonitorvalid.ToString();
                    break;

                case Scopexportablestoremonitor.EntityMonitorText:
                    stringValue = reflect.Scopexportablemonitortext.ToString();
                    break;

                case Scopexportablestoremonitor.EntityMonitorQuery:
                    stringValue = reflect.Scopexportablemonitorquery.ToString();
                    break;

                case Scopexportablestoremonitor.EntityMonitorTransform:
                    stringValue = reflect.Scopexportablemonitortransform.ToString();
                    break;

                default:
                    stringValue = default;
                    break;
            }

            var concat = String.Concat(stringValue, ScopexportableradicalNewLine.NewLineConcatenate);

            var result = concat;

            stringResult = result;

            return stringResult;
        }
    }
}