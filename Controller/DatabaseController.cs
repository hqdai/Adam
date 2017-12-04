using DotNetNuke.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MDP.Controller
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

        public string Adam_Assets_Add()
        {
            return string;
        }

        public int AddItem(ItemInfo objItemInfo)
        {
            int ItemID = 0;
            string storename = "Adam_Assets_Add";
            using (IDataContext ctx = DataContext.Instance())
            {
                ItemID = ctx.ExecuteScalar<int>(System.Data.CommandType.StoredProcedure, storename, 
                    objItemInfo.Title, 
                    objItemInfo.Description, 
                    objItemInfo.AssignedUserId, 
                    objItemInfo.ModuleId, 
                    objItemInfo.Sort, 
                    objItemInfo.CreatedOnDate, 
                    objItemInfo.CreatedByUserId, 
                    objItemInfo.LastModifiedOnDate, 
                    objItemInfo.LastModifiedByUserId);
            }
            return ItemID;
        }
    }
}
