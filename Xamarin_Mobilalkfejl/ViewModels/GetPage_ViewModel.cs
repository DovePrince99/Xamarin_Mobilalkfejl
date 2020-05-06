using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;
using Xamarin_Mobilalkfejl.Model;

namespace Xamarin_Mobilalkfejl.ViewModels
{
    internal class GetPage_ViewModel
    {
        public GetPage_ViewModel()
        {
            this.MyFilamentList = new ObservableCollection<Filament>();
        }
        ObservableCollection<Filament> myFilamentList;
        public ObservableCollection<Filament> MyFilamentList
        {
            get { return myFilamentList; }
            set
            {
                myFilamentList = value;

                OnPropertyRaised("MyFilamentList");
            }



        }
        #region NotifyPropChanged

        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyRaised(string propertyname)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyname));
        }

        #endregion

        public void FillList_TestMethod()
        {
            this.MyFilamentList.Add(new Filament
            {
                Type = "PLA",
                Color = "Green",
                Mass = "100 g"
            });
            this.MyFilamentList.Add(new Filament
            {
                Type = "PLA",
                Color = "Blavk",
                Mass = "200 g"
            });
            this.MyFilamentList.Add(new Filament
            {
                Type = "PLA",
                Color = "Red",
                Mass = "300 g"
            });
        }
    }
}