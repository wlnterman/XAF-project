using DevExpress.ExpressApp.DC;
using DevExpress.Persistent.Base;
using DevExpress.Persistent.BaseImpl.EF;
using System.Collections.ObjectModel;

namespace MySolution.Module.BusinessObjects
{
    [DefaultClassOptions]
    [ImageName("BO_Resume")]
    public class Resume : BaseObject
    {

        [Aggregated]
        public virtual IList<PortfolioFileData> Portfolio { get; set; } = new ObservableCollection<PortfolioFileData>();

        public virtual Employee Employee { get; set; }

        [Aggregated]
        public virtual FileData File { get; set; }
    }
}