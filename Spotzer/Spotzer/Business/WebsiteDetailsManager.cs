using Spotzer.Data;
using Spotzer.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Spotzer.Business
{
    public class WebsiteDetailsManager
    {
        #region CRUD operations
        /// <summary>
        /// Used to insert the websitedetails
        /// </summary>
        /// <param name="websitedetails">This will have the websitedetails as an object</param>
        /// <returns></returns>
        public static void Save(tbl_websitedetails websitedetails)
        {
            try
            {
                using (SpotzerEntities db = new SpotzerEntities())
                {
                    tbl_websitedetails existwebsitedetails = db.tbl_websitedetails.FirstOrDefault(r => r.ID == websitedetails.ID);
                    if (existwebsitedetails == null)
                    {
                        existwebsitedetails = websitedetails;
                        existwebsitedetails.CreatedOn = DateTime.Now;
                        existwebsitedetails.CreatedBy = null;
                        db.tbl_websitedetails.Add(websitedetails);
                        db.SaveChanges();
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
        }
        #endregion CRUD operations
    }
}