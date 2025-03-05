using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace BindCommandToComboBoxItemViaControlTemplate
{
    public static class ComboBoxHelper
    {
        public static DelegateCommand<object> GetComboBoxItemClickCommand(DependencyObject obj)
        {
            return (DelegateCommand<object>)obj.GetValue(ComboBoxItemClickCommandProperty);
        }

        public static void SetComboBoxItemClickCommand(DependencyObject obj, DelegateCommand<object> value)
        {
            obj.SetValue(ComboBoxItemClickCommandProperty, value);
        }

        public static readonly DependencyProperty ComboBoxItemClickCommandProperty =
            DependencyProperty.RegisterAttached("ComboBoxItemClickCommand", typeof(DelegateCommand<object>), typeof(ComboBoxHelper), new PropertyMetadata(null));

        public static object GetComboBoxItemClickCommandParameter(DependencyObject obj)
        {
            return (object)obj.GetValue(ComboBoxItemClickCommandParameterProperty);
        }

        public static void SetComboBoxItemClickCommandParameter(DependencyObject obj, object value)
        {
            obj.SetValue(ComboBoxItemClickCommandParameterProperty, value);
        }

        public static readonly DependencyProperty ComboBoxItemClickCommandParameterProperty =
            DependencyProperty.RegisterAttached("ComboBoxItemClickCommandParameter", typeof(object), typeof(ComboBoxHelper), new PropertyMetadata(null));


    }
}
