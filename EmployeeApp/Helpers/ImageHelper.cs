using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EmployeeApp.Helpers
{ 
    // Class to convert Model.Image which is saved in varbinary to base string
    public class ImageHelper
    {
        public string GetImage(byte[] imageInBytes)
        {
            string imgSrc = null;
            if (imageInBytes != null)
            {
                var base64 = Convert.ToBase64String(imageInBytes);
                imgSrc = string.Format("data:image/png;base64,{0}", base64);
                return imgSrc;
            }
            return null;
        }
    }
            
}