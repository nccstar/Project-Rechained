﻿using SingleplayerLauncher.Model;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

public class ComboBoxHelper<T>
{
    private ToolTip toolTip;
    private Dictionary<string, T> items;
    private Func<T, string> getToolTipText;
    private Action<Graphics, Rectangle, T> drawItemShape;
    private string currentTooltipText;
    private ComboBox currentComboBox;

    public ComboBoxHelper(Dictionary<string, T> items, Func<T, string> getToolTipText, Action<Graphics, Rectangle, T> drawItemShape)
    {
        toolTip = new ToolTip();
        this.items = items;
        this.getToolTipText = getToolTipText;
        this.drawItemShape = drawItemShape;
    }

    public void InitializeComboBox(ComboBox comboBox)
    {
        comboBox.DrawMode = DrawMode.OwnerDrawFixed;
        comboBox.DrawItem += ComboBox_DrawItem;
        comboBox.DropDownClosed += ComboBox_DropDownClosed;
    }

    private void ComboBox_DrawItem(object sender, DrawItemEventArgs e)
    {
        ComboBox comboBox = (ComboBox)sender;

        if (e.Index < 0) { return; }

        string itemName = comboBox.GetItemText(comboBox.Items[e.Index]);
        if (!items.TryGetValue(itemName, out T item)) {  return; }

        // Draw the background
        if ((e.State & DrawItemState.Selected) == DrawItemState.Selected)
        {
            e.Graphics.FillRectangle(SystemBrushes.Highlight, e.Bounds);
        }
        else
        {
            e.Graphics.FillRectangle(SystemBrushes.Window, e.Bounds);
        }

        // Draw the item text
        using (Brush brush = new SolidBrush((e.State & DrawItemState.Selected) == DrawItemState.Selected ? SystemColors.HighlightText : SystemColors.ControlText))
        {
            int xPadding = drawItemShape != null ? 25 : 0;
            e.Graphics.DrawString(itemName, e.Font, brush, e.Bounds.X + xPadding, e.Bounds.Y);
        }

        if ((e.State & DrawItemState.Selected) == DrawItemState.Selected)
        {
            currentTooltipText = getToolTipText(item);
            currentComboBox = comboBox;

            // To show the tool tips only when the ComboBox is open
            if ((e.State & DrawItemState.ComboBoxEdit) != DrawItemState.ComboBoxEdit)
            {
                toolTip.Show(currentTooltipText, currentComboBox, e.Bounds.Right, e.Bounds.Bottom);
            }

            // Focus is a low-level method intended primarily for custom control
            // authors. Instead, application programmers should use the Select
            // method or the ActiveControl property for child controls, or the
            // Activate method for forms.
            // https://learn.microsoft.com/en-us/dotnet/api/system.windows.forms.control.focus?view=windowsdesktop-8.0&redirectedfrom=MSDN#System_Windows_Forms_Control_Focus
            e.DrawFocusRectangle();
        }
    }

    private void ComboBox_DropDownClosed(object sender, EventArgs e)
    {
        toolTip.Hide((Control)sender);
    }
}

public class TraitComboBoxHelper : ComboBoxHelper<Trait>
{
    public TraitComboBoxHelper(Dictionary<string, Trait> traits)
        : base(traits, GetToolTipText, DrawItemShape)
    {
    }

    private static string GetToolTipText(Trait trait)
    {
        return $"{trait.Name}\n\n{trait.Description}\n\nMatching Bonus: {trait.MatchingBonusTrait.Description}";
    }

    private static void DrawItemShape(Graphics g, Rectangle bounds, Trait trait)
    {
        Color shapeColor;
        Action<Graphics, Rectangle> drawShape;

        switch (trait.MatchingSlot)
        {
            case Trait.TRIANGLE_BONUS_SLOT:
                shapeColor = Color.Yellow;
                drawShape = DrawTriangle;
                break;
            case Trait.DIAMOND_BONUS_SLOT:
                shapeColor = Color.Blue;
                drawShape = DrawDiamond;
                break;
            case Trait.PENTAGON_BONUS_SLOT:
                shapeColor = Color.Green;
                drawShape = DrawPentagon;
                break;
            default:
                shapeColor = Color.Black;
                drawShape = DrawRectangle; // Default shape
                break;
        }

        using (Brush brush = new SolidBrush(shapeColor))
        {
            drawShape(g, bounds);
        }
    }

    private static void DrawTriangle(Graphics g, Rectangle bounds)
    {
        Point[] points = new Point[]
        {
            new Point(bounds.X + 10, bounds.Y + bounds.Height - 5),
            new Point(bounds.X + 20, bounds.Y + bounds.Height - 5),
            new Point(bounds.X + 15, bounds.Y + bounds.Height - 15)
        };
        g.FillPolygon(Brushes.Gold, points);
    }

    private static void DrawDiamond(Graphics g, Rectangle bounds)
    {
        Point[] points = new Point[]
        {
            new Point(bounds.X + 15, bounds.Y + bounds.Height - 15),
            new Point(bounds.X + 20, bounds.Y + bounds.Height - 10),
            new Point(bounds.X + 15, bounds.Y + bounds.Height - 5),
            new Point(bounds.X + 10, bounds.Y + bounds.Height - 10)
        };
        g.FillPolygon(Brushes.LightSkyBlue, points);
    }

    private static void DrawPentagon(Graphics g, Rectangle bounds)
    {
        Point[] points = new Point[]
        {
            new Point(bounds.X + 15, bounds.Y + bounds.Height - 15),
            new Point(bounds.X + 20, bounds.Y + bounds.Height - 10),
            new Point(bounds.X + 18, bounds.Y + bounds.Height - 5),
            new Point(bounds.X + 12, bounds.Y + bounds.Height - 5),
            new Point(bounds.X + 10, bounds.Y + bounds.Height - 10)
        };
        g.FillPolygon(Brushes.LightGreen, points);
    }

    private static void DrawRectangle(Graphics g, Rectangle bounds)
    {
        g.FillRectangle(Brushes.Gray, bounds);
    }
}


public class SlotItemComboBoxHelper : ComboBoxHelper<SlotItem>
{
    public SlotItemComboBoxHelper(Dictionary<string, SlotItem> slotitems)
        : base(slotitems, GetToolTipText, null)
    {
    }

    private static string GetToolTipText(SlotItem slotItem)
    {
        return $"{slotItem.Name}\n\n{slotItem.Description}";
    }
}

public class TrapPartComboBoxHelper : ComboBoxHelper<TrapPart>
{
    public TrapPartComboBoxHelper(Dictionary<string, TrapPart> trapParts)
        : base(trapParts, GetToolTipText, null)
    {
    }

    private static string GetToolTipText(TrapPart trapPart)
    {
        return $"{trapPart.Name}\n\n{trapPart.Description}";
    }
}

public class GuardianComboBoxHelper : ComboBoxHelper<Guardian>
{
    public GuardianComboBoxHelper(Dictionary<string, Guardian> guardians)
        : base(guardians, GetToolTipText, null)
    {
    }

    private static string GetToolTipText(Guardian guardian)
    {
        return $"{guardian.Name}\n\n{guardian.AuraText}";
    }
}

public class ConsumableComboBoxHelper : ComboBoxHelper<Consumable>
{
    public ConsumableComboBoxHelper(Dictionary<string, Consumable> consumables)
        : base(consumables, GetToolTipText, null)
    {
    }

    private static string GetToolTipText(Consumable consumable)
    {
        return $"{consumable.Name}\n\n{consumable.Description}";
    }
}