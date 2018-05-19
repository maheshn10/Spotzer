using AutoMapper;
using Spotzer.Data;
using Spotzer.Helpers;
using Spotzer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Spotzer.Business
{
    public class OrderManager
    {
        #region CRUD operations
        /// <summary>
        /// Used to insert the order
        /// </summary>
        /// <param name="order">This will have the order details as an object</param>
        /// <returns></returns>
        public static int Save(tbl_order order)
        {
            int _id = 0;
            try
            {
                using (SpotzerEntities db = new SpotzerEntities())
                {
                    tbl_order existOrder = db.tbl_order.FirstOrDefault(r => r.OrderID == order.OrderID);
                    if (existOrder == null)
                    {
                        existOrder = order;
                        existOrder.CreatedOn = DateTime.Now;
                        existOrder.CreatedBy = null;
                        db.tbl_order.Add(existOrder);
                        db.SaveChanges();
                        _id = existOrder.ID;
                    }
                    else
                    {
                        throw new CustomException(Constants.StatusMessage.OrderExist,Constants.StatusCode.kErrorOrderExists);
                    }

                }
            }
            catch (CustomException ex)
            {
                throw new CustomException(ex.Message,ex.ErrorCode);
            }
            return _id;
        }

        #endregion CRUD operations

        #region Non CRUD operations
        /// <summary>
        /// Used to insert the order
        /// </summary>
        /// <param name="Order">This will have the placement details and the list of products of the order like Partner, OrderID, TypeOfOrder, etc. as an object</param>
        /// <returns></returns>
        public static Status PlaceOrder(Order Order)
        {            
            Status Status = new Status();
            try
            {
                
                tbl_order tbl_order = new tbl_order();
                tbl_order = Mapper.Map<Order, tbl_order>(Order);
                int _orderid = OrderManager.Save(tbl_order);
                
                foreach (LineItem lineitem in Order.LineItems)
                        {
                            tbl_lineitem tbl_lineitem = new tbl_lineitem();
                            tbl_lineitem = Mapper.Map<LineItem, tbl_lineitem>(lineitem);
                            int _lineitemid = LineItemManager.Save(tbl_lineitem);
                            if (lineitem.WebsiteDetails != null)
                            {
                                tbl_websitedetails tbl_websitedetails = new tbl_websitedetails();
                                tbl_websitedetails = Mapper.Map<WebsiteDetails, tbl_websitedetails>(lineitem.WebsiteDetails);
                                WebsiteDetailsManager.Save(tbl_websitedetails);
                            }
                            if (lineitem.AdWordCampaign != null)
                            {
                                tbl_adwordcampaign tbl_adwordcampaign = new tbl_adwordcampaign();
                                tbl_adwordcampaign = Mapper.Map<AdWordCampaign, tbl_adwordcampaign>(lineitem.AdWordCampaign);
                                AdWordCampaignManager.Save(tbl_adwordcampaign);
                            }
                        }
                
                Status.Code = Constants.StatusCode.kSuccessInserted;
                Status.Message = Constants.StatusMessage.Inserted;
            }
            catch (CustomException ex)
            {
                Status.Code = ex.ErrorCode;
                Status.Message = ex.Message;
            }

            return Status;
        }

        #endregion Non CRUD operations
    }
}