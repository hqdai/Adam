using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CloudinaryDotNet;
using CloudinaryDotNet.Actions;

namespace Adam.Controller
{
    public class CloudiaryController
    {
        string Cloudname = "mrdzen";
        string APIKey = "924589665466888";
        string APISecret = "_orGXLDJpFw2Hrv_LpqvpWMe8H4";

        private static CloudiaryController _instance;
        public static CloudiaryController Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new CloudiaryController();
                }
                return _instance;
            }
        }

        public ImageUploadResult UploadPhoto(string filePath)
        {
            Account acc = new Account(Cloudname, APIKey, APISecret);
            Cloudinary cloudinary = new Cloudinary(acc);

            var uploadParams = new ImageUploadParams()
            {
                File = new FileDescription(filePath)
            };
            //uploadParams.PublicId = "dzen";
            //uploadParams.Tags = "dzen,alo,123";
            var uploadResult = cloudinary.Upload(uploadParams);

            return uploadResult;
        }

    }
}
