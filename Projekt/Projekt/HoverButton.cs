using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace Projekt
{
    class HoverButton : Button
    {
        public static readonly DependencyProperty HoverColorProperty = DependencyProperty.Register("HoverColor", typeof(Brush), typeof(HoverButton));

        public Brush HoverColor
        {
            get => (Brush)GetValue(HoverColorProperty);
            set => SetValue(HoverColorProperty, value);
        }

        public static readonly DependencyProperty CornerRadiusProperty = DependencyProperty.Register("CornerRadius", typeof(CornerRadius), typeof(HoverButton));

        public CornerRadius CornerRadius
        {
            get => (CornerRadius)GetValue(CornerRadiusProperty);
            set => SetValue(CornerRadiusProperty, value);
        }
    }
}
