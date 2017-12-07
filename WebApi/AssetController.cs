using DotNetNuke.Security;
using DotNetNuke.Web.Api;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Adam.Model;
using Adam.Controller;
using System;
using DotNetNuke.Common.Utilities;
using DotNetNuke;
using System.Web;

namespace Adam.WebApi
{
    public class AssetController : DnnApiController
    {
        [HttpGet]
        [ActionName("test")]
        [AllowAnonymous]
        public HttpResponseMessage HelloWorld()
        {
           AssetInfo info = new AssetInfo();
            return Request.CreateResponse(HttpStatusCode.OK, info.ToJson());
        }


        [HttpPost]
        [ActionName("UploadFile")] // /API/item/new
        [AllowAnonymous]
        public HttpResponseMessage AddItem()
        {
            string returnID = "a";
            try
            {
                int i = 0;
                var httpRequest = HttpContext.Current.Request;
                if (httpRequest.Files.Count < 1)
                {
                    return Request.CreateResponse(HttpStatusCode.BadRequest);
                }

                foreach (string file in httpRequest.Files)
                {
                    var postedFile = httpRequest.Files[file];
                    var filePath = HttpContext.Current.Server.MapPath("~/Portals/UploadedAssets/" + postedFile.FileName);
                    postedFile.SaveAs(filePath);
                    //UPload to Cloudiary
                    returnID = CloudiaryController.Instance.UploadPhoto(filePath).PublicId;
                    //i++;
                }
                return Request.CreateResponse(HttpStatusCode.Created, returnID);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }

        [HttpPost]
        [ActionName("New")] // /API/item/new
        [AllowAnonymous]
        public HttpResponseMessage AddItem(AssetInfo item)
        {
            try
            {
                var httpRequest = HttpContext.Current.Request;
                ////if (httpRequest.Files.Count < 1)
                ////{
                ////    return Request.CreateResponse(HttpStatusCode.BadRequest);
                ////}

                foreach (string file in httpRequest.Files)
                {
                    var postedFile = httpRequest.Files[file];
                    var filePath = HttpContext.Current.Server.MapPath("~/Portals/UploadedAssets/" + postedFile.FileName);
                    postedFile.SaveAs(filePath);
                    // NOTE: To store in memory use postedFile.InputStream
                }

                //item.CreatedBy = UserInfo.UserID;
                //item.DateAdded = DateTime.Now;
                //item.ModifiedBy = UserInfo.UserID;
                //item.DateModified = DateTime.Now;
                DatabaseController.Instance.Adam_Assets_Add(item);
                return Request.CreateResponse(HttpStatusCode.Created);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }
    }
}
