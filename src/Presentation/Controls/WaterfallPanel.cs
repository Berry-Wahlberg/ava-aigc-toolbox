using Avalonia;
using Avalonia.Controls;
using Avalonia.Layout;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BerryAIGCToolbox.Controls;

/// <summary>
/// 瀑布流面板，实现不规则网格布局
/// </summary>
public class WaterfallPanel : Panel
{
    /// <summary>
    /// 列数属性
    /// </summary>
    public static readonly StyledProperty<int> ColumnCountProperty = 
        AvaloniaProperty.Register<WaterfallPanel, int>(nameof(ColumnCount), 3);
    
    /// <summary>
    /// 列间距属性
    /// </summary>
    public static readonly StyledProperty<double> ColumnSpacingProperty = 
        AvaloniaProperty.Register<WaterfallPanel, double>(nameof(ColumnSpacing), 10);
    
    /// <summary>
    /// 行间距属性
    /// </summary>
    public static readonly StyledProperty<double> RowSpacingProperty = 
        AvaloniaProperty.Register<WaterfallPanel, double>(nameof(RowSpacing), 10);
    
    /// <summary>
    /// 列数
    /// </summary>
    public int ColumnCount
    {
        get => GetValue(ColumnCountProperty);
        set => SetValue(ColumnCountProperty, value);
    }
    
    /// <summary>
    /// 列间距
    /// </summary>
    public double ColumnSpacing
    {
        get => GetValue(ColumnSpacingProperty);
        set => SetValue(ColumnSpacingProperty, value);
    }
    
    /// <summary>
    /// 行间距
    /// </summary>
    public double RowSpacing
    {
        get => GetValue(RowSpacingProperty);
        set => SetValue(RowSpacingProperty, value);
    }
    
    /// <inheritdoc/>
    protected override Size MeasureOverride(Size availableSize)
    {
        if (Children.Count == 0)
            return new Size(0, 0);
        
        // 计算每列的宽度
        int actualColumnCount = Math.Min(ColumnCount, Children.Count);
        double totalSpacing = (actualColumnCount - 1) * ColumnSpacing;
        double columnWidth = (availableSize.Width - totalSpacing) / actualColumnCount;
        
        // 测量每个子元素
        foreach (var child in Children)
        {
            child.Measure(new Size(columnWidth, double.PositiveInfinity));
        }
        
        // 计算每列的高度
        var columnHeights = new double[actualColumnCount];
        
        for (int i = 0; i < Children.Count; i++)
        {
            int columnIndex = i % actualColumnCount;
            columnHeights[columnIndex] += Children[i].DesiredSize.Height + RowSpacing;
        }
        
        // 移除最后一个元素的行间距
        for (int i = 0; i < actualColumnCount; i++)
        {
            if (columnHeights[i] > 0)
                columnHeights[i] -= RowSpacing;
        }
        
        return new Size(availableSize.Width, columnHeights.Max());
    }
    
    /// <inheritdoc/>
    protected override Size ArrangeOverride(Size finalSize)
    {
        if (Children.Count == 0)
            return finalSize;
        
        // 计算每列的宽度
        int actualColumnCount = Math.Min(ColumnCount, Children.Count);
        double totalSpacing = (actualColumnCount - 1) * ColumnSpacing;
        double columnWidth = (finalSize.Width - totalSpacing) / actualColumnCount;
        
        // 记录每列的当前高度
        var columnYPositions = new double[actualColumnCount];
        
        for (int i = 0; i < Children.Count; i++)
        {
            var child = Children[i];
            
            // 找到高度最小的列
            int columnIndex = 0;
            double minHeight = columnYPositions[0];
            for (int j = 1; j < actualColumnCount; j++)
            {
                if (columnYPositions[j] < minHeight)
                {
                    minHeight = columnYPositions[j];
                    columnIndex = j;
                }
            }
            
            // 计算子元素的位置
            double x = columnIndex * (columnWidth + ColumnSpacing);
            double y = columnYPositions[columnIndex];
            
            // 排列子元素
            child.Arrange(new Rect(x, y, columnWidth, child.DesiredSize.Height));
            
            // 更新列高度
            columnYPositions[columnIndex] += child.DesiredSize.Height + RowSpacing;
        }
        
        return finalSize;
    }
}