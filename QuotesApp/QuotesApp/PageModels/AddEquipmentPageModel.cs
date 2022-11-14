using FreshMvvm;
using QuotesApp.Interface;
using QuotesApp.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using Xamarin.Forms;

namespace QuotesApp.PageModels
{
    public class AddEquipmentPageModel : FreshBasePageModel
    {
        private IRestService _restService;
        public Command  AddEquipmentCommand { get; set; }
       


        public AddEquipmentPageModel(IRestService restService)
        {
            _restService = restService;
            AddEquipmentCommand = new Command(AddEquipment);
        }

        private async void AddEquipment(object obj)
        {

            try
            {
                var equipment = new Equipment()
                {
                    Id = Guid.NewGuid(),
                    Name = Name,
                    StatusName = StatusName,
                    TypeName = TypeName,
                    Status = Status,
                    Type = Type,
                    Quantity = Quantity,
                };
                var result = await _restService.PostEquipment(equipment);
                if(result)
                    await CoreMethods.DisplayAlert("Success", "Your equipment has been added successfully", "Close");
                    Name = "";
                    statusName = "";
                    TypeName = "";
                    await CoreMethods.PushPageModel<EquipmentPageModel>();
                
            }
            catch (Exception ex)
            {
                await CoreMethods.DisplayAlert("Oops", ex.Message, "close");
                throw;
            }

        }

        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private string statusName;

        public string StatusName
        {
            get { return statusName; }
            set { statusName = value; }
        }

        private string typeName;

        public string TypeName
        {
            get { return typeName; }
            set { typeName = value; }
        }

        private int status;

        public int Status
        {
            get { return status; }
            set { status = value; }
        }

        private int type;

        public int Type
        {
            get { return type; }
            set { type = value; }
        }

        private int quantity;

        public int Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }
    }
}
