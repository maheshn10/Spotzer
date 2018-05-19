using Spotzer.Data;
using Spotzer.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Spotzer.Business
{
    public class AdWordCampaignManager
    {
        #region CRUD operations
        /// <summary>
        /// Used to insert the adwordcampaign
        /// </summary>
        /// <param name="adwordcampaign">This will have the adwordcampaign as an object</param>
        /// <returns></returns>
        public static void Save(tbl_adwordcampaign adwordcampaign)
        {
            try
            {
                using (SpotzerEntities db = new SpotzerEntities())
                {
                    tbl_adwordcampaign existadwordcampaign = db.tbl_adwordcampaign.FirstOrDefault(r => r.ID == adwordcampaign.ID);
                    if (existadwordcampaign == null)
                    {
                        existadwordcampaign = adwordcampaign;
                        existadwordcampaign.CreatedOn = DateTime.Now;
                        existadwordcampaign.CreatedBy = null;
                        db.tbl_adwordcampaign.Add(adwordcampaign);
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