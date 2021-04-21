using SimplePhotoDiary.Data_Access_Layer;
using SimplePhotoDiary.Data_Access_Layer.Entities;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimplePhotoDiary.Service_Layer
{
    class ImageDataService
    {
        ImageDataAccess imageDataAccess;

       

        public ImageDataService()
        {
            this.imageDataAccess = new ImageDataAccess();
        }

        public List<Images> GetImageList(int eventid)
        {
            return this.imageDataAccess.GetImages(eventid);
        }

        public Images GetTheImage (int imageid)
        {
            return this.imageDataAccess.GetImage(imageid);
        }

        public int AddImage(byte[] pictures,string story, string modificationDate, int eventId)
        {
            Images image = new Images() {Pictures  = pictures , Story = story, ModificationDate = modificationDate, EventId = eventId };
            return this.imageDataAccess.AddAnImage(image);

        }

        public int UpdateImage(byte[] images ,string story, string modificationDate, int imageId)
        {
            Images image = new Images() {Pictures = images ,Story = story, ModificationDate = modificationDate, ImageId = imageId };
            return this.imageDataAccess.UpdateAnImage(image);
        }

        public int DeleteImage(int imageId)
        {
            return this.imageDataAccess.DeleteAnImage(imageId);
        }

        public byte[] ByteConversion(Image receive)
        {
            return this.imageDataAccess.ConvertImageToBytes(receive);
        }

        public Image ImageConversion(byte[] image)
        {
            return this.imageDataAccess.ConvertBytesToImage(image);
        }

        public Image BrowseImage()
        {

            return this.imageDataAccess.BrowseAnImage();
        }


    }
}
