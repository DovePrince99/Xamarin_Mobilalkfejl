using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Xamarin_Mobilalkfejl.Model;
using Xamarin_Mobilalkfejl.ViewModels;

namespace Xamarin_Mobilalkfejl
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class GetFilamentStorage_LeftPage : ContentPage
    {
        GetPage_ViewModel model = new GetPage_ViewModel();
        public GetFilamentStorage_LeftPage()
        {
            InitializeComponent();
           /*  model.MyFilamentList.Add(new Filament()
            {
                Type = "Pla",
                Color = "Black",
                Mass = "3000 g"
            }); */
            BindingContext = model;
        }
    }
}