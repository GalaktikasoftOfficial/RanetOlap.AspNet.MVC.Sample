using Ranet.Analytics.PivotGrid.Server.Mvc;

namespace Ranet.PivotTable.MVC
{
    public class LayoutItem : IDynamicPivotGridLayoutItem
    {
        public DynamicPivotGridLayoutItemType Type { get; set; }
        public DynamicPivotGridLayoutArea Area { get; set; }
        public string Caption { get; set; }
        public string UniqueName { get; set; }
    }
}