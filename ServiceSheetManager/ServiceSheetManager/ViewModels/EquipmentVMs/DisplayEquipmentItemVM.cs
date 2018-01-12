﻿using ServiceSheetManager.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ServiceSheetManager.ViewModels.EquipmentVMs
{
    public class DisplayEquipmentItemVM
    {
        private readonly int id;
        private string barcode;
        private string description;
        private string serialNumber;
        private int? calibrationPeriodYears;

        public DisplayEquipmentItemVM(Equipment equipmentModel)
        {
            this.id = equipmentModel.Id;
            this.barcode = equipmentModel.Barcode;
            this.description = equipmentModel.Description;
            this.serialNumber = equipmentModel.SerialNumber;
            this.CalibrationPeriodYears = equipmentModel.CalibrationPeriodYears;
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
        [Display(Name = "Serial Number")]
        public string SerialNumber
        {
            get { return serialNumber; }
            set { serialNumber = value; }
        }
        [Display(Name = "Calibration Period (Years)")]
        public Nullable<int> CalibrationPeriodYears
        {
            get { return calibrationPeriodYears; }
            set { calibrationPeriodYears = value; }
        }
    }
}