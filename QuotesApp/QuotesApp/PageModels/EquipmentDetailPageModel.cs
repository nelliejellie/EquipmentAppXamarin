using FreshMvvm;
using QuotesApp.Models;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace QuotesApp.PageModels
{
    public class EquipmentDetailPageModel : FreshBasePageModel
    {
        public Equipment Equipment { get; set; }
        public Command CopyEquipmentCommand { get; set; }
        public Command ShareEquipmentCommand { get; set; }

        public EquipmentDetailPageModel()
        {
            CopyEquipmentCommand = new Command(CopyEquipment);
            ShareEquipmentCommand = new Command(ShareEquipment);
        }

        private void ShareEquipment(object obj)
        {
            Share.RequestAsync(Equipment.Name);
        }

        private void CopyEquipment(object obj)
        {
            Clipboard.SetTextAsync(Equipment.Name);
        }

        public override void Init(object initData)
        {
            base.Init(initData);
            Equipment = (Equipment)initData;
        }

    }
}
