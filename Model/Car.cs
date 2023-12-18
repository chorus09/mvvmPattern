using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace mvvm.Model {
    public class Car : INotifyPropertyChanged {

        private string? _name;
        private double _enginePower;
        private int _horsePower;
        private double _price;

        public Car(string? name, double enginePower, int horsePower, double price) {
            Name = name;
            EnginePower = enginePower;
            HorsePower = horsePower;
            Price = price;
        }

        public string? Name {
            get => _name;
            set {
                if (_name == value) return;
                _name = value;
                OnPropertyChanged(nameof(Name));
            }
        }
        public double EnginePower {
            get => _enginePower;
            set {
                if(_enginePower == value) return;
                _enginePower = value;
                OnPropertyChanged(nameof(EnginePower));
            }
        }

        public int HorsePower {
            get => _horsePower;
            set {
                if (_horsePower == value) return;
                _horsePower = value;
                OnPropertyChanged(nameof(HorsePower));
            }
        }

        public double Price {
            get => _price;
            set {
                if( _price == value) return;
                _price = value;
                OnPropertyChanged(nameof(Price));
            }
        }

        public event PropertyChangedEventHandler? PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string? property = "") {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(property));
        }
    }
}
