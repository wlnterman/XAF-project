using DevExpress.Persistent.Base;
using DevExpress.Persistent.BaseImpl.EF;
using DevExpress.Persistent.Validation;
using System.ComponentModel;
using DevExpress.Persistent.Validation;

namespace MySolution.Module.BusinessObjects
{
    [DefaultClassOptions]
    [DefaultProperty(nameof(Title))]
    public class Position : BaseObject
    {
        /*Define a validation rule that ensures that the `Position.Title` property
          has a value when you save the `Position` object.*/
        [RuleRequiredField(DefaultContexts.Save)]
        public virtual string Title { get; set; }
    }
}
