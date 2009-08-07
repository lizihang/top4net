using System;
using System.Collections.Generic;

using Taobao.Top.Api;

namespace Taobao.Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.traderate.add
    /// </summary>
    public class TradeRateAddRequest : ITopRequest
    {
        /// <summary>
        /// 交易ID。
        /// </summary>
        public string Tid { get; set; }

        /// <summary>
        /// 子订单ID。
        /// </summary>
        public string OrderId { get; set; }

        /// <summary>
        /// 评价内容。
        /// </summary>
        public string Content { get; set; }

        /// <summary>
        /// 评价结果。
        /// </summary>
        public string Result { get; set; }

        /// <summary>
        /// 是否匿名（是:true;否:false;）卖家评不能匿名。
        /// </summary>
        public string Anonymous { get; set; }

        /// <summary>
        /// 评价角色。
        /// </summary>
        public string Role { get; set; }

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.traderate.add";
        }

        public IDictionary<string, string> GetParameters()
        {
            IDictionary<string, string> parameters = new Dictionary<string, string>();

            parameters.Add("tid", this.Tid);
            parameters.Add("order_id", this.OrderId);
            parameters.Add("content", this.Content);
            parameters.Add("result", this.Result);
            parameters.Add("anony", this.Anonymous);
            parameters.Add("role", this.Role);

            return parameters;
        }

        #endregion
    }
}