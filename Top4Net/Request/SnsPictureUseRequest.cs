using System;
using System.Collections.Generic;

using Taobao.Top.Api;

namespace Taobao.Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.sns.picture.setUsed
    /// </summary>
    public class SnsPictureUseRequest : ITopRequest
    {
        /// <summary>
        /// 图片文件编号列表。
        /// </summary>
        public string PicIds { get; set; }

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.sns.picture.setUsed";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();

            parameters.Add("ids", this.PicIds);

            return parameters;
        }

        #endregion
    }
}