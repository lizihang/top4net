using System;
using System.Collections.Generic;

using Taobao.Top.Api;

namespace Taobao.Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.fullskus.get
    /// </summary>
    public class SkusCustomGetRequest : ITopRequest
    {
        /// <summary>
        /// 外部商家编号。
        /// </summary>
        public string OuterId { get; set; }

        /// <summary>
        /// 需要返回的字段。
        /// </summary>
        public string Fields { get; set; }

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.fullskus.get";
        }

        public IDictionary<string, string> GetParameters()
        {
            IDictionary<string, string> parameters = new Dictionary<string, string>();

            parameters.Add("outer_id", this.OuterId);
            parameters.Add("fields", this.Fields);

            return parameters;
        }

        #endregion
    }
}
