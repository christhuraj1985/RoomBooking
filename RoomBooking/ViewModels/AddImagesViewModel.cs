﻿using RoomBooking.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RoomBooking.ViewModels
{
    public class AddImagesViewModel
    {
        public List<string> UploadErrors { get; set; }
        public List<Image> AddedImages { get; set; }
    }
}
