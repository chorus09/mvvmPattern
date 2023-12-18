using System.Windows;
using mvvm.ViewModel;

namespace mvvm;
public partial class MainWindow : Window
{
    public MainWindow() {
        InitializeComponent();
        DataContext = new MainWndViewModel();
    }
}