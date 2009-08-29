using System;
using System.Collections.Generic;

using Taobao.Top.Api;

namespace Taobao.Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.refund.messages.get
    /// </summary>
    public class RefundMessagesGetRequest : ITopRequest
    {
        /// <summary>
        /// 需要返回的字段。
        /// </summary>
        public string Fields { get; set; }

        /// <summary>
        /// 退款单号。
        /// </summary>
        public string Rid { get; set; }

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.refund.messages.get";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();

            parameters.Add("refund_id", this.Rid);
            parameters.Add("fields", this.Fields);

            return parameters;
        }

        #endregion
    }
}