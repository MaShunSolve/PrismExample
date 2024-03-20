using Prism.Ioc;
using Prism.Unity;
using PrismExample.Interface;
using PrismExample.Service;
using PrismExample.Views;
using System.Configuration;
using System.Data;
using System.Windows;

namespace PrismExample
{
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
            containerRegistry.Register<ICustomerStore, DbCustomerStore>();
        }
    }
}
