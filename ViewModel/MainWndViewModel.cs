using mvvm.Model;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace mvvm.ViewModel
{
    public class MainWndViewModel : INotifyPropertyChanged {
        public MainWndViewModel() {
            Cars = new ObservableCollection<Car>() {
                new Car("Toyota", 3.0, 329, 40500),
                new Car("BMW", 2.5, 184, 6500),
                new Car("Mercedes", 4.0, 320, 22000),
                new Car("Dacia", 1.2, 50, 3000)
            };
        }
        private Car? _selectedCar;

        public Car? SelectedCar {
            get => _selectedCar;
            set {
                if(value == _selectedCar) return;
                _selectedCar = value;
                OnPropertyChanged(nameof(SelectedCar));
            }
        }

        public ObservableCollection<Car>? Cars { get; set; }

        public event PropertyChangedEventHandler? PropertyChanged;

        public void OnPropertyChanged([CallerMemberName] string property = "") {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(property));
        }
    }
}
