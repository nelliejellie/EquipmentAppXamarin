using FreshMvvm;
using QuotesApp.Interface;
using QuotesApp.PageModels;
using QuotesApp.Pages;
using QuotesApp.Services;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace QuotesApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            FreshIOC.Container.Register<IRestService, RestServices>();

            var mainPage = FreshPageModelResolver.ResolvePageModel<EquipmentPageModel>(); ;
            var navigationContainer = new FreshNavigationContainer(mainPage);
            MainPage = navigationContainer;
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
