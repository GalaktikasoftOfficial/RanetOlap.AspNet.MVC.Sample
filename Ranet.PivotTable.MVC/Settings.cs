using Ranet.Analytics.PivotGrid.Server.Mvc;

namespace Ranet.PivotTable.MVC
{
	public class Settings : IDynamicPivotGridQueryDesignerSettings
	{
		public bool GenerateCustomCalculated { get; set; }
		public bool HideEmptyColumns { get; set; }
		public bool HideEmptyRows { get; set; }
		public bool IncludeAllMembers { get; set; }
		public bool IncludeCustomCalculationsInDrillDown { get; set; }
		public int SubsetCount { get; set; }
		public bool UseVisualTotals { get; set; }
		public bool UseHierarchize { get; set; }
	}
}