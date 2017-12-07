using DotNetNuke.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Adam.Model;

namespace Adam.Controller
{
    class DatabaseController
    {
        /// <summary>
        /// The private field holding the instance 
        /// </summary>
        private static DatabaseController _instance;

        /// <summary>
        /// Gets the instance (singleton pattern).
        /// </summary>
        /// <value>The instance.</value>
        public static DatabaseController Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new DatabaseController();
                }
                return _instance;
            }
        }

        public void Adam_Assets_Add(AssetInfo Info)
        {
            string storename = "Adam_Assets_Add";
            using (IDataContext ctx = DataContext.Instance())
            {
                ctx.Execute(System.Data.CommandType.StoredProcedure, storename,
                    Info.AssetID,
                    Info.ItemID,
                    Info.AssetType,
                    Info.ItemType,
                    Info.IsDeleted,
                    Info.DateAdded,
                    Info.DateModified,
                    Info.CreatedBy,
                    Info.ModifiedBy);
            }
        }
    }
}
