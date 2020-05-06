using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;
using Xamarin_Mobilalkfejl.Model;

namespace Xamarin_Mobilalkfejl.Services
{
    class StoredData
    {
        //Fields
        static private ObservableCollection<Filament> commonFilamentList;
        //Properties
        public ObservableCollection<Filament> CommonFilamentList
        {
            get { return commonFilamentList; }
            set
            {
                commonFilamentList = value;
                OnPropertyRaised("CommonFilamentList");
            }
        }
        static StoredData storedFilament { get; set; }
        static public StoredData GetStoredData()
        {
            if (storedFilament == null)
            {
                storedFilament = new StoredData();
                storedFilament.CommonFilamentList = new ObservableCollection<Filament>();
            }
            return storedFilament;
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
