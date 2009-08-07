using System;
using System.IO;
using System.Collections.Generic;

namespace Taobao.Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.product.add
    /// </summary>
    public class ProductAddRequest : ITopUploadRequest
    {
        /// <summary>
        /// 类目ID。
        /// </summary>
        public string Cid { get; set; }

        /// <summary>
        /// 外部产品ID。
        /// </summary>
        public string OuterId { get; set; }

        /// <summary>
        /// 关键属性pid:vid;pid:vid ,如果碰到用户自定义属性，请用custom_props。
        /// </summary>
        public string Props { get; set; }

        /// <summary>
        /// 绑定属性,根据类目确定绑定属性是否是必须。
        /// </summary>
        public string BindProps { get; set; }

        /// <summary>
        /// 销售属性。
        /// </summary>
        public string SaleProps { get; set; }

        /// <summary>
        /// 用户自定义属性，1636953:DDFAFAEED。
        /// </summary>
        public string CustomProps { get; set; }

        /// <summary>
        /// 产品名称。
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 产品市场价。
        /// </summary>
        public string Price { get; set; }

        /// <summary>
        /// 产品描述。
        /// </summary>
        public string Desc { get; set; }

        /// <summary>
        /// 产品主图，要先上传图片后再提交测试，否则产品图片不会被提交。
        /// </summary>
        public FileInfo Image { get; set; }

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.product.add";
        }

        public IDictionary<string, string> GetParameters()
        {
            IDictionary<string, string> parameters = new Dictionary<string, string>();

            parameters.Add("cid", this.Cid);
            parameters.Add("outer_id", this.OuterId);
            parameters.Add("props", this.Props);
            parameters.Add("binds", this.BindProps);
            parameters.Add("sale_props", this.SaleProps);
            parameters.Add("customer_props", this.CustomProps);
            parameters.Add("name", this.Name);
            parameters.Add("price", this.Price);
            parameters.Add("desc", this.Desc);

            return parameters;
        }

        #endregion

        #region ITopUploadRequest Members

        public IDictionary<string, FileInfo> GetFileParameters()
        {
            IDictionary<string, FileInfo> parameters = new Dictionary<string, FileInfo>();
            parameters.Add("image", this.Image);
            return parameters;
        }

        #endregion
    }
}