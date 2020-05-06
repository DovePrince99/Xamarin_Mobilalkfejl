using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using Xamarin_Mobilalkfejl.Model;
namespace Xamarin_Mobilalkfejl.ViewModels
{
    class AddPage_ViewModel
    {
        //Fields
        string infoOfEntrys;
        string type_FromEntry;
        string color_FromEntry;
        string mass_FromEntry;

        //Properties
        public string InfoOFEntrys 
        { 
            get {return infoOfEntrys; }
            set
            {
                infoOfEntrys = value;
                OnPropertyRaised("InfoOfEntrys"); 
            }
        }
        public string Type_FromEntry
        {
            get { return type_FromEntry; }
            set
            {
                type_FromEntry = value;
                OnPropertyRaised("Type_FromEntry");
            }
        }
        public string Color_FromEntry
        {
            get { return color_FromEntry; }
            set
            {
                color_FromEntry = value;
                OnPropertyRaised("Color_FromEntry");
            }
        }
        public string Mass_FromEntry
        {
            get { return mass_FromEntry; }
            set
            {
                mass_FromEntry = value;
                OnPropertyRaised("Mass_FromEntry");
            }
        }
        #region NotifyPropChanged

        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyRaised(string propertyname)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyname));
        }

        #endregion
    }
}
