using System.Drawing;
using Ranet.Analytics.PivotGrid.Server.Mvc;

namespace Ranet.PivotTable.MVC
{
    public class CustomCalculatedItem : IDynamicPivotGridCustomCalculatedItem
    {
        public string Caption { get; set; }
        public string Expression { get; set; }
        public Color ForeColor { get; set; }
        public Color BackColor { get; set; }
        public DynamicPivotGridCustomCalculatedItemType Type { get; set; }
    }
}