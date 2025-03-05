using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace DockPanelTest;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    private void Window_MouseDoubleClick(object sender, MouseButtonEventArgs e)
    {
        var btn1D = DockPanel.GetDock(this.btn1);
        var btn2D = DockPanel.GetDock(this.btn2);
        var btn3D = DockPanel.GetDock(this.btn3);
    }
}