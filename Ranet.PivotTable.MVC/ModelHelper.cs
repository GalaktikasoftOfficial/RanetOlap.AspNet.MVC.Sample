using System.Collections.Generic;
using System.Drawing;
using Ranet.Analytics.PivotGrid.Server.Mvc;

namespace Ranet.PivotTable.MVC
{
    public static class ModelHelper
    {
        public static IList<IDynamicPivotGridPage> GetPages()
        {
            var pages = new List<IDynamicPivotGridPage>
            {
                new Page
                {
                    Id = "0",
                    Caption = "First page",
                    CubeName = "[Adventure Works]",
                    AutoExecuteMdxQuery = true,
                    PlacementLayoutModeQueryDesigner = 0,
                    LayoutItems =
                    {
                        new LayoutItem
                        {
                            Caption = "[Set 0]",
                            Type = DynamicPivotGridLayoutItemType.CalculatedNamedSet,
                            Area = DynamicPivotGridLayoutArea.Columns
                        },
                        new LayoutItem
                        {
                            UniqueName = "[Product].[Product Categories]",
                            Type = DynamicPivotGridLayoutItemType.Hierarchy,
                            Area = DynamicPivotGridLayoutArea.Rows
                        },
                        new LayoutItem
                        {
                            UniqueName = "[Scenario].[Scenario].[Scenario]",
                            Type = DynamicPivotGridLayoutItemType.Level,
                            Area = DynamicPivotGridLayoutArea.Rows
                        },
                        new LayoutItem
                        {
                            Type = DynamicPivotGridLayoutItemType.Values,
                            Area = DynamicPivotGridLayoutArea.Rows
                        },
                        new LayoutItem
                        {
                            UniqueName = "[Measures].[Amount]",
                            Type = DynamicPivotGridLayoutItemType.Measure,
                            Area = DynamicPivotGridLayoutArea.Data
                        },
                        new LayoutItem
                        {
                            UniqueName = "[Measures].[Customer Count]",
                            Type = DynamicPivotGridLayoutItemType.Measure,
                            Area = DynamicPivotGridLayoutArea.Data
                        },
                        new LayoutItem
                        {
                            Caption = "[My custom 'Amount']",
                            Type = DynamicPivotGridLayoutItemType.CalculatedMember,
                            Area = DynamicPivotGridLayoutArea.Data
                        },
                        new LayoutItem
                        {
                            UniqueName = "[Measures].[Financial Variance Status]",
                            Type = DynamicPivotGridLayoutItemType.KpiItem,
                            Area = DynamicPivotGridLayoutArea.Data
                        }
                    },
                    CustomCalculatedItems =
                    {
                        new CustomCalculatedItem
                        {
                            Caption = "[My custom 'Amount']",
                            Expression = "[Measures].[Amount] * 2 / 10",
                            ForeColor = Color.FromArgb(255, 255, 255, 255),
                            BackColor = Color.FromArgb(255, 0, 150, 150),
                            Type = DynamicPivotGridCustomCalculatedItemType.CalculatedMember
                        },
                        new CustomCalculatedItem { Caption = "[Set 0]", Expression = "[Summary P&L]", Type = DynamicPivotGridCustomCalculatedItemType.CalculatedNamedSet }
                    },
                    ShowMetadataAndQueryDesigner = true,
                    QueryDesignerSettings =
                    {
                        GenerateCustomCalculated = false,
                        HideEmptyColumns = true,
                        HideEmptyRows = false,
                        IncludeAllMembers = false,
                        IncludeCustomCalculationsInDrillDown = false,
                        SubsetCount = 0,
                        UseVisualTotals = true
                    }
                },
                new Page
                {
                    Id = "1",
                    Caption = "Second page",
                    CubeName = "[Adventure Works]",
                    AutoExecuteMdxQuery = true,
                    PlacementLayoutModeQueryDesigner = 4,
                    LayoutItems =
                    {
                        new LayoutItem
                        {
                            UniqueName = "[Scenario].[Scenario].[Scenario]",
                            Type = DynamicPivotGridLayoutItemType.Level,
                            Area = DynamicPivotGridLayoutArea.Columns
                        },
                        new LayoutItem
                        {
                            UniqueName = "[Product].[Product Categories]",
                            Type = DynamicPivotGridLayoutItemType.Hierarchy,
                            Area = DynamicPivotGridLayoutArea.Rows
                        },
                        new LayoutItem
                        {
                            UniqueName = "[Measures].[Amount]",
                            Type = DynamicPivotGridLayoutItemType.Measure,
                            Area = DynamicPivotGridLayoutArea.Data
                        }
                    },
                    QueryDesignerSettings =
                    {
                        HideEmptyRows = false
                    }
                },
                new Page
                {
                    Id = "2",
                    Caption = "Third page",
                    CubeName = "[Adventure Works]",
                    AutoExecuteMdxQuery = true,
                    PlacementLayoutModeQueryDesigner = 1,
                    LayoutItems =
                    {
                        new LayoutItem
                        {
                            UniqueName = "[Geography].[Country].[Country]",
                            Type = DynamicPivotGridLayoutItemType.Level,
                            Area = DynamicPivotGridLayoutArea.Columns
                        },
                        new LayoutItem
                        {
                            UniqueName = "[Date].[Fiscal].[Fiscal Year]",
                            Type = DynamicPivotGridLayoutItemType.Level,
                            Area = DynamicPivotGridLayoutArea.Rows
                        }
                    }
                }
            };

            return pages;
        }
    }
}