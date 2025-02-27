using BindCommandToComboBoxItemViaControlTemplate.Views;
using System.Configuration;
using System.Data;
using System.Windows;

namespace BindCommandToComboBoxItemViaControlTemplate;

/// <summary>
/// Interaction logic for App.xaml
/// </summary>
public partial class App : PrismApplication
{
    protected override Window CreateShell()
    {
        var w = Container.Resolve<MainWindow>();
        return w;
    }

    protected override void RegisterTypes(IContainerRegistry containerRegistry)
    {
        containerRegistry.Register<ICustomerStoreService, DbCustomerStoreService>();
    }
}

