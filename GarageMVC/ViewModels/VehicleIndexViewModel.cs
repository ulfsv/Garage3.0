﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace GarageMVC.ViewModels
{
    public class VehicleIndexViewModel
    {
        [DisplayName("User")]
        public string UserName { get; set; }

        [DisplayName("Vehicle Type")]
        public string VehicleType { get; set; }

        [DisplayName("Licence Number")]
        public string LicenceNr { get; set; }

        [DisplayName("Parked time")]
        public int ParkedHours { get; set; }
    }
}
