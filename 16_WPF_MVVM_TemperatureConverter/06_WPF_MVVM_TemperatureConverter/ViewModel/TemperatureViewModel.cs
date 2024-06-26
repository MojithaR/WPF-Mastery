using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System; // Importing the System namespace
using System.ComponentModel; // Importing the System.ComponentModel namespace for implementing INotifyPropertyChanged
using System.Windows.Input; // Importing the System.Windows.Input namespace for ICommand 
using _06_WPF_MVVM_TemperatureConverter.Model;// Importing the Models namespace for TemperatureModel
using System.CodeDom.Compiler;

namespace _06_WPF_MVVM_TemperatureConverter.ViewModel  // Defining the namespace for the ViewModels
{
    public class TemperatureViewModel : INotifyPropertyChanged 
        // Defining the TemperatureViewModel class implementing INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged; // Event for property change notification

        private TemperatureModel temperatureModel = new TemperatureModel(); // Creating an instance of TemperatureModel

        public double Celsius // Property for Celsius temperature
        {
            get { return temperatureModel.Celsius; } // Getter for Celsius
            set { temperatureModel.Celsius = value; OnPropertyChanged(nameof(Celsius)); } 
            // Setter for Celsius with property change notification
        }

        public double Fahrenheit // Property for Fahrenheit temperature
        {
            get { return temperatureModel.Fahrenheit; } // Getter for Fahrenheit
            set { temperatureModel.Fahrenheit = value; OnPropertyChanged(nameof(Fahrenheit)); } 
            // Setter for Fahrenheit with property change notification
        }

        public double Kelvin // Property for Kelvin temperature
        {
            get { return temperatureModel.Kelvin; } // Getter for Kelvin
            set { temperatureModel.Kelvin = value; OnPropertyChanged(nameof(Kelvin)); } 
            // Setter for Kelvin with property change notification
        }

        public TemperatureViewModel() // Constructor for TemperatureViewModel
        {
            ConvertCommand = new RelayCommand(ConvertTemperatures); // Initializing ConvertCommand with ConvertTemperatures method
            ClearCommand = new RelayCommand(ClearTemperatures); // Initializing ClearCommand with ClearTemperatures method
        }

        public ICommand ConvertCommand { get; } // Property for ConvertCommand of type ICommand
        public ICommand ClearCommand { get; } // Property for ClearCommand of type ICommand

        private void ConvertTemperatures(object obj) // Method to convert temperatures
        {
            Fahrenheit = (Celsius * 9.0 / 5.0) + 32; // Convert Celsius to Fahrenheit
            Kelvin = Celsius + 273.15; // Convert Celsius to Kelvin
        }

        private void ClearTemperatures(object obj) // Method to clear temperatures
        {
            Celsius = 0; // Reset Celsius
            Fahrenheit = 0; // Reset Fahrenheit
            Kelvin = 0; // Reset Kelvin
        }

        private void OnPropertyChanged(string propertyName) // Method to raise property change notification
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName)); // Invoke PropertyChanged event
        }
    }

    public class RelayCommand : ICommand // RelayCommand class implementing ICommand
  //This class helps in connecting commands from the View to the ViewModel.
    {
        private readonly Action<object> execute; 
        // It holds an action (a method) that needs to be executed when the command is triggered.

        public RelayCommand(Action<object> executeAction) // Constructor for RelayCommand
        //When a RelayCommand is created, it needs an action to be passed in, which will be executed when the command is triggered.
        {
            execute = executeAction; // Assigning executeAction to execute
        }

        public event EventHandler CanExecuteChanged; // Event for CanExecuteChanged
        //This method determines if the command can be executed.In this case, it always returns true, meaning the command can always be executed.

        public bool CanExecute(object parameter) // Method to determine if the command can be executed
        {
            return true; // Always return true for simplicity
        }

        public void Execute(object parameter) // Method to execute the command
        //This method actually performs the action that was assigned to the RelayCommand when it was created.
        //It executes the action passed in as a parameter.
        {
            execute(parameter); // Execute the action
        }
    }
}