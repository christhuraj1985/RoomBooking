using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RoomBooking.Models;
using RoomBooking.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RoomBooking.Controllers
{
   // [Authorize]
    public class ImagesController : Controller
    {
        private readonly IGenericHotelService<Image> _hotelService;

        public ImagesController(IGenericHotelService<Image> genericHotelService)
        {
            _hotelService = genericHotelService;
        }


        // GET: Images
        public async Task<IActionResult> Index()
        {
            return View(await _hotelService.GetAllItemsAsync());
        }

        // GET: Images
        public async Task<IActionResult> GetAllImagesJson()
        {
            var images = await _hotelService.GetAllItemsAsync();
            return PartialView("GetAllImagesPartial", images);
        }

        // GET: Images/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var image = await _hotelService.GetItemByIdAsync(id);

            if (image == null)
            {
                return NotFound();
            }


            return View(image);
        }

        // GET: Images/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Images/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(List<IFormFile> files)
        {
            var result = await _hotelService.AddImagesAsync(files);
            var AddedImages = new List<string>();
            foreach (var image in result.AddedImages)
            {
                AddedImages.Add(image.Name + " Added Successfully");
            }
            ViewData["AddedImages"] = AddedImages;
            ViewData["UploadErrors"] = result.UploadErrors;
            return View();
        }

       
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(string id)
        {
            var image = await _hotelService.GetItemByIdAsync(id);
            await _hotelService.RemoveImageAsync(image);
            return RedirectToAction(nameof(Index));
        }


    }
}
