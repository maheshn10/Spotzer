using Spotzer.Data;
using Spotzer.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Spotzer.Business
{
    public class LineItemManager
    {
        #region CRUD operations
        /// <summary>
        /// Used to insert the Lineietem
        /// </summary>
        /// <param name="lineitem">This will have the Line Item details as an object</param>
        /// <returns></returns>
        public static int Save(tbl_lineitem lineitem)
        {
            int _id = 0;
            try
            {
                using (SpotzerEntities db = new SpotzerEntities())
                {
                    tbl_lineitem existLineItem = db.tbl_lineitem.FirstOrDefault(r => r.ID == lineitem.ID);
                    if (existLineItem == null)
                    {
                        existLineItem = lineitem;
                        existLineItem.CreatedOn = DateTime.Now;
                        existLineItem.CreatedBy = null;
                        db.tbl_lineitem.Add(existLineItem);
                        db.SaveChanges();
                        _id = existLineItem.ID;
                    }
                    else
                    {
                        throw new CustomException(Constants.StatusMessage.Error, Constants.StatusCode.kSuccessDefault);
                    }

                }
            }
            catch (CustomException ex)
            {
                throw new CustomException(ex.Message, ex.ErrorCode);
            }
            return _id;
        }

        #endregion CRUD operations
    }
}