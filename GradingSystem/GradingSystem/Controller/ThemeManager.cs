using System;
using System.Drawing;
using System.Windows.Forms;

public static class ThemeManager
{
    public static bool IsDarkMode { get; set; } = false;

    private static readonly Color LightBackground = Color.White;
    private static readonly Color DarkBackground = Color.FromArgb(18, 18, 18);
    private static readonly Color LightText = Color.Black;
    private static readonly Color DarkText = Color.White;

    public static void ApplyTheme(Form form, Color? customBackground = null, Color? customText = null)
    {
        Color backgroundColor = IsDarkMode ? DarkBackground : LightBackground;
        Color textColor = IsDarkMode ? DarkText : LightText;

        backgroundColor = customBackground ?? backgroundColor;
        textColor = customText ?? textColor;

        form.BackColor = backgroundColor;
        form.ForeColor = textColor;

        foreach (Control ctrl in form.Controls)
        {
            if (ctrl.Tag != null && ctrl.Tag.ToString() == "NoTheme")
            {
                continue;
            }

            if (ctrl is Button button)
            {
                button.BackColor = IsDarkMode ? Color.FromArgb(50, 50, 50) : Color.Black;
                button.ForeColor = textColor;
            }
            else if (ctrl is Label label)
            {
                label.ForeColor = IsDarkMode ? Color.White : Color.Black;
            }
            else if (ctrl is TextBox textBox)
            {
                textBox.BackColor = IsDarkMode ? Color.FromArgb(30, 30, 30) : LightBackground;
                textBox.ForeColor = textColor;
            }
        }
    }
}
