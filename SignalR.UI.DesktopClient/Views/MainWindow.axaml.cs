using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace SignalR.UI.DesktopClient.Views
{
    public class MainWindow : Window
    {
        public string chatContent { get; set; }

        public MainWindow()
        {
            InitializeComponent();
#if DEBUG
            this.AttachDevTools();
#endif
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }

        private void Connect()
        {

        }
    }
}
