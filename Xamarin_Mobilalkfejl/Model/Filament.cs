using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Xamarin_Mobilalkfejl.Model
{
    class Filament
    {
        // Fields
        private string type;
        private string color;
        private string mass;

        //Properties
        public string Type
        {
            get { return type; }
            set { type = value; OnPropertyRaised("Type"); }
        }
        public string Color
        {
            get { return color; }
            set { color = value; OnPropertyRaised("Color"); }
        }
        public string Mass
        {
            get { return mass; }
            set { mass = value; OnPropertyRaised("Mass"); }
        }
        // NotifyEvent
        #region NotifyPropChanged

        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyRaised(string propertyname)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyname));
        }

        #endregion
    }
}
