using System;
using System.Collections.Generic;

using Taobao.Top.Api;

namespace Taobao.Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.product.propImg.delete
    /// </summary>
    public class ProductPropImgDeleteRequest : ITopRequest
    {
        /// <summary>
        /// 属性图片ID。
        /// </summary>
        public string ImgId { get; set; }

        /// <summary>
        /// 产品ID。
        /// </summary>
        public string ProductId { get; set; }

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.product.propImg.delete";
        }

        public IDictionary<string, string> GetParameters()
        {
            IDictionary<string, string> parameters = new Dictionary<string, string>();

            parameters.Add("pic_id", this.ImgId);
            parameters.Add("product_id", this.ProductId);

            return parameters;
        }

        #endregion
    }
}