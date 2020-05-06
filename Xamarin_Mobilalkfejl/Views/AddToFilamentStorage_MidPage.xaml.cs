using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using Xamarin_Mobilalkfejl.Model;
using Xamarin_Mobilalkfejl.ViewModels;
using Xamarin_Mobilalkfejl.Services;

namespace Xamarin_Mobilalkfejl
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    
    public partial class AddToFilamentStorage_MidPage : ContentPage
    {
        //CommonData
        StoredData commmonModel = StoredData.GetStoredData();
        //BindingContextModel
        AddPage_ViewModel model = new AddPage_ViewModel();
        public AddToFilamentStorage_MidPage()
        {
            InitializeComponent();
            model.InfoOFEntrys = "Give me data!";
            BindingContext = model;
        }

        private void Save_Clicked(object sender, EventArgs e)
        {
            commmonModel.CommonFilamentList.Add(new Filament()
            {
                Type = model.Type_FromEntry,
                Color = model.Color_FromEntry,
                Mass = model.Mass_FromEntry
            });
        }
    }
}