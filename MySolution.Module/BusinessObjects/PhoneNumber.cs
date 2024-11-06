using DevExpress.Persistent.Base;
using DevExpress.Persistent.BaseImpl.EF;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace MySolution.Module.BusinessObjects
{

    [DefaultProperty(nameof(Number))]
    public class PhoneNumber : BaseObject
    {
        public virtual string Number { get; set; }

        public virtual string PhoneType { get; set; }
        public override String ToString()
        {
            return Number;
        }
        public virtual Employee Employee { get; set; }

    }
}
