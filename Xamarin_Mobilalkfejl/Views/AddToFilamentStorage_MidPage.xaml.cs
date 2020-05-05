using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Xamarin_Mobilalkfejl.ViewModels;

namespace Xamarin_Mobilalkfejl
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    
    public partial class AddToFilamentStorage_MidPage : ContentPage
    {
        AddPage_ViewModel model = new AddPage_ViewModel();
        public AddToFilamentStorage_MidPage()
        {
            InitializeComponent();
            model.InfoOFEntrys = "Give me data!";
            BindingContext = model;
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
          
        }
    }
}