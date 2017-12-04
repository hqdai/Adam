using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adam.Model
{
    public class AssetInfo
    {
        public string AssetID { get;set; }
        public string ItemID { get; set; }
        public string AssetType { get; set; }
        public string ItemType { get; set; }
        public string Host { get; set; }
        public string URL { get; set; }
        public string IsDeleted { get; set; }
        public string DateAdded { get; set; }
        public string DateModified { get; set; }
        public string CreatedBy { get; set; }
        public string ModifiedBy { get; set; }
    }
}
