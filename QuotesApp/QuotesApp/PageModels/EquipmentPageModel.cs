using FreshMvvm;
using QuotesApp.Interface;
using QuotesApp.Models;
using QuotesApp.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using Xamarin.Forms;

namespace QuotesApp.PageModels
{
    public class EquipmentPageModel : FreshBasePageModel
    {
        public ObservableCollection<Equipment> Equipments { get; set; }
        private IRestService _restService;
        public Command AddEquipmentCommand { get; set; }
        public EquipmentPageModel(IRestService restService)
        {
            _restService = restService;
            Equipments = new ObservableCollection<Equipment>();
            LoadEquipments();
            AddEquipmentCommand = new Command(AddEquipment);
           
        }

        private void AddEquipment(object obj)
        {
            CoreMethods.PushPageModel<AddEquipmentPageModel>();
        }

        private bool isBusy = true;

        public bool IsBusy
        {
            get { return isBusy; }
            set { 
                    isBusy = value;
                    RaisePropertyChanged();
                }
        }

        private async void LoadEquipments()
        {
            var equipments = await _restService.GetEquipments();
            
            equipments.ForEach(x => Equipments.Add(x));
            IsBusy = false;

        }

        private Equipment equipment;

        public Equipment SelectedEquipment
        {
            get { return null; }
            set { 
                    equipment = value;
                    if(equipment != null)
                    {
                         CoreMethods.PushPageModel<EquipmentDetailPageModel>(SelectedEquipment);
                        RaisePropertyChanged();
                    }
                }
        }

    }
}
