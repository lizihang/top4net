using System;
using System.Collections.Generic;

namespace Taobao.Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.item.update.showcase
    /// </summary>
    public class ItemRecommendAddRequest : ITopPrivateRequest
    {
        /// <summary>
        /// 会话码。
        /// </summary>
        private string sessionKey;

        /// <summary>
        /// 需要橱窗推荐的商品id。
        /// </summary>
        public string ItemId { get; set; }

        /// <summary>
        /// 产品主图文件绝对地址。
        /// </summary>
        public string PrimaryPicPath { get; set; }

        public ItemRecommendAddRequest(string sessionKey)
        {
            if (string.IsNullOrEmpty(sessionKey))
            {
                throw new ArgumentNullException("sessionKey");
            }
            this.sessionKey = sessionKey;
        }

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.item.update.showcase";
        }

        public IDictionary<string, string> GetParameters()
        {
            IDictionary<string, string> parameters = new Dictionary<string, string>();

            parameters.Add("iid", this.ItemId);

            return parameters;
        }

        #endregion

        #region ITopPrivateRequest Members

        public string GetSessionKey()
        {
            return this.sessionKey;
        }

        #endregion
    }
}