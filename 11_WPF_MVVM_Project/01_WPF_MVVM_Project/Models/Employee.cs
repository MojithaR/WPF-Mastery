using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel;
namespace _01_WPF_MVVM_Project.Models
{
    //use WPF data binding feature..2 way data binding feature
    //To binding the data we can use eather dependancy properties or interface collars
    public class Employee : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged; //if property was changed we can use this event handler
        private void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));

        }

        //Employees ID
        private int id;
        public int Id
        { get { return id; } set {  id = value; OnPropertyChanged("Id"); } }

        //Employees Name
        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; OnPropertyChanged("Name");}
        }
        
        //Employee Age
        private string age;
        public string Age
        { 
            get { return age; } 
            set { age = value; OnPropertyChanged("Age"); } 
        }
        




    }
}
