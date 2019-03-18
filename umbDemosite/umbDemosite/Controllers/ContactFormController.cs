using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using umbDemosite.Implementation;
using umbDemosite.Models;
using Umbraco.Core;
using Umbraco.Core.Services.Implement;
using Umbraco.Web.Mvc;
using Umbraco.Core.Models;
using Umbraco.Core.Models.PublishedContent;
using Umbraco.Core.Services;
using Umbraco.Web;

namespace umbDemosite.Controllers
{
    public class ContactFormController : SurfaceController
    {
        // GET: Tour
        [HttpPost]
        public ActionResult Submit(TourViewModel model, HttpPostedFileBase file)
        {
            if (!ModelState.IsValid)
                return CurrentUmbracoPage();

            //if (file.ContentLength > 0)
            //{
            //    var fileName = Path.GetFileName(file.FileName);
            string imgPath = @"D:\3Capture.PNG";


            var ms = Services.MediaService;

            using (var file1 = new FileStream(imgPath, FileMode.Open))
            {
                var parent = ms.GetRootMedia().FirstOrDefault(); // or -1 for root media object
                var media = ms.CreateMedia("TestImage", parent, Constants.Conventions.MediaTypes.Image);
                System.Drawing.Image sourceimage = System.Drawing.Image.FromStream(file1);
                media.SetValue(Constants.Conventions.Media.File, file1); // save image inside folder
                var mediaSaved = ms.Save(media);
            }
            //}

            CreateTour();
            //Work with form data here
            return RedirectToCurrentUmbracoPage();
        }


        private void CreateTour()
        {
            int userId = 0;
            IContentService cs = Services.ContentService;
            IPublishedContent home = Umbraco.AssignedContentItem.AncestorOrSelf("home");
            var homePage = CurrentPage.AncestorOrSelf("home");
            //var MyContent = Umbraco.Content(1111).Url();
            var umbesEntityService = Services.EntityService;
            var sdsd = umbesEntityService.GetKey(homePage.Id, UmbracoObjectTypes.Document);
            var id = "umb://document/" + sdsd;
            //Udi udi = Udi.Parse(id) ;

            //if (Udi.TryParse(id, out udi))
            //{
            //    return udi.ToPublishedContent();
            //}

            //IPublishedContent gContent = umbracoHelper.TypedContent(1111);
            var gid = new Guid("0b949542-2625-4a11-9516-5c6446b26eca");
            //var content = cs.Create("Tour2", new Guid(sdsd.ToString()), "Tour", userId);
            var content = cs.Create("Tour3", gid, "Tour", userId);
            // Umbraco.
            //content.SetValue("Name", "Test121");
            content.SetValue("HeroTitle", "Test121");
            content.SetValue("HeroDescription", "Hike one of the most beautiful mountain landscapes in the world. Italy’s dramatic rocky rooftop, the Dolomites offer spectacular views and lovely surroundings, especially on this spring tour. You will enjoy the wild Alpine meadows, snow-tipped peaks and cobblestone mountain villages. We will take scenic paths from Cortina d’ Ampezzo to Alta Badia and learn about the fascinating history of the region along the way.");
            cs.SaveAndPublish(content, "*", -1, true);
        }

    }
}