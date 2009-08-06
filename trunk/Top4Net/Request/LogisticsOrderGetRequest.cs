using System;
using System.Collections.Generic;

using Taobao.Top.Api;

namespace Taobao.Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.shippings.send.get
    /// </summary>
    public class LogisticsOrderGetRequest : ITopRequest
    {
        /// <summary>
        /// 查询字段。
        /// </summary>
        public string Fields { get; set; }

        /// <summary>
        /// 交ID 注: 如果加入tid参数的话,不用传其他的参数,但是仅会返回一条物流订单信息。
        /// </summary>
        public string Tid { get; set; }

        /// <summary>
        /// 买家昵称。
        /// </summary>
        public string BuyerNick { get; set; }

        /// <summary>
        /// 物流状态 : 查看数据结构状态。
        /// </summary>
        public string Status { get; set; }

        /// <summary>
        /// 卖家是否发货: 是(yes) 否(no)。
        /// </summary>
        public string SellerConfirm { get; set; }

        /// <summary>
        /// 收货人姓名。
        /// </summary>
        public string ReceiverName { get; set; }

        /// <summary>
        /// 创建时间开始。
        /// </summary>
        public string StartCreated { get; set; }

        /// <summary>
        /// 创建时间结束。
        /// </summary>
        public string EndCreated { get; set; }

        /// <summary>
        /// 谁承担运费:买家/buyer 卖家/seller。
        /// </summary>
        public string FreightPayer { get; set; }

        /// <summary>
        /// 平邮(post) 快递(express) EMS(ems)。
        /// </summary>
        public string Type { get; set; }

        /// <summary>
        /// 页码。
        /// </summary>
        public string PageNo { get; set; }

        /// <summary>
        /// 每页条数。
        /// </summary>
        public string PageSize { get; set; }

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.shippings.send.get";
        }

        public IDictionary<string, string> GetParameters()
        {
            IDictionary<string, string> parameters = new Dictionary<string, string>();

            parameters.Add("fields", this.Fields);
            parameters.Add("tid", this.Tid);
            parameters.Add("buyer_nick", this.BuyerNick);
            parameters.Add("status", this.Status);
            parameters.Add("seller_confirm", this.SellerConfirm);
            parameters.Add("receiver_name", this.ReceiverName);
            parameters.Add("start_created", this.StartCreated);
            parameters.Add("end_created", this.EndCreated);
            parameters.Add("freight_payer", this.FreightPayer);
            parameters.Add("type", this.Type);
            parameters.Add("page_no", this.PageNo);
            parameters.Add("page_size", this.PageSize);

            return parameters;
        }

        #endregion
    }
}
