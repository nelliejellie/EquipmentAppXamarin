using FreshMvvm;
using QuotesApp.Models;
using QuotesApp.Services;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace QuotesApp.PageModels
{
    public class HomePageModel : FreshBasePageModel
    {
        public Command GoBackCommand { get; set; }


        public HomePageModel()
        {
            GoBackCommand = new Command(GoBack);
        }


        // getting data parsed from welcomepage
        public override void Init(object initData)
        {
            base.Init(initData);
            string parameter = (string)initData;
        }

        private void GoBack(object obj)
        {
            CoreMethods.PopPageModel("Hello Im Back");
        }

        
    }
}
