using RoomBooking.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RoomBooking.ViewModels
{
    public class RoomsAdminIndexViewModel
    {
        public List<Room> Rooms { get; set; }
        public List<RoomType> RoomTypes { get; set; }
    }
}
