using System.Collections.Generic;
using System.Linq;
using Ranet.Analytics.PivotGrid.Server.Mvc;

namespace Ranet.PivotTable.MVC
{
    public class Page : IDynamicPivotGridPage
    {
        #region IDynamicPivotGridPage

        public string Id { get; set; }
        public string Caption { get; set; }
        public string CubeName { get; set; }
        public bool AutoExecuteMdxQuery { get; set; }
        public int PlacementLayoutModeQueryDesigner { get; set; }
        public object OnHistoryChangedEvent { get; set; }
        public bool ShowMetadataAndQueryDesigner { get; set; }
        public IDynamicPivotGridQueryDesignerSettings GetQueryDesignerSettings()
        {
            return this.QueryDesignerSettings;
        }
        public IList<IDynamicPivotGridLayoutItem> GetFields()
        {
            return this.LayoutItems.Cast<IDynamicPivotGridLayoutItem>().ToList();
        }
        public IList<IDynamicPivotGridCustomCalculatedItem> GetCustomCalculatedItems()
        {
            return this.CustomCalculatedItems.Cast<IDynamicPivotGridCustomCalculatedItem>().ToList();
        }

        #endregion IDynamicPivotGridPage

        private Settings _queryDesignerSettings;
        public Settings QueryDesignerSettings
        {
            get { return this._queryDesignerSettings ?? (this._queryDesignerSettings = new Settings()); }
        }

        private IList<LayoutItem> _layoutItems;
        public IList<LayoutItem> LayoutItems
        {
            get { return this._layoutItems ?? (this._layoutItems = new List<LayoutItem>()); }
        }
        private IList<CustomCalculatedItem> _customCalculatedItems;
        public IList<CustomCalculatedItem> CustomCalculatedItems
        {
            get { return this._customCalculatedItems ?? (this._customCalculatedItems = new List<CustomCalculatedItem>()); }
        }        
    }
}