﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using ServiceSheetManager.Models;

namespace ServiceSheetManager.ViewModels.EquipmentVMs
{
    public class EquipmentIndexKitItemVM
    {
        private int id;
        private string barcode;
        private string description;
        private string currentLocation;

        public EquipmentIndexKitItemVM(EquipmentKit kitEquipment)
        {
            id = kitEquipment.Id;
            Barcode = kitEquipment.Barcode;
            Description = kitEquipment.Description;
            CurrentLocation = "To do";
        }

        public int Id
        {
            get { return id; }
        }
        public string Barcode
        {
            get { return barcode; }
            set { barcode = value; }
        }
        public string Description
        {
            get { return description; }
            set { description = value; }
        }
        [Display(Name = "Current Location")]
        public string CurrentLocation
        {
            get { return currentLocation; }
            set { currentLocation = value; }
        }
    }
}