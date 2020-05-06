using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Xamarin_Mobilalkfejl.Model;
using Xamarin_Mobilalkfejl.Services;
using Xamarin_Mobilalkfejl.ViewModels;

namespace Xamarin_Mobilalkfejl
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class GetFilamentStorage_LeftPage : ContentPage
    {
        //CommonData
        StoredData commmonModel = StoredData.GetStoredData();
        //BindingContextModel
        GetPage_ViewModel model = new GetPage_ViewModel();
        public GetFilamentStorage_LeftPage()
        {
            // model.FillList_TestMethod();
            commmonModel.CommonFilamentList = model.MyFilamentList;
            InitializeComponent();
           
            BindingContext = model;
        }

       
    }

}