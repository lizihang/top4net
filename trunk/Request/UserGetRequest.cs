using System;
using System.Collections.Generic;
using Top.Api.Response;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.user.get
    /// </summary>
    public class UserGetRequest : ITopRequest<UserGetResponse>
    {
        /// <summary>
        /// 需返回的字段列表。可选值：User结构体中的所有字段；以半角逗号(,)分隔。不支持：地址，真实姓名，身份证，手机，电话，邮箱
        /// </summary>
        public string Fields { get; set; }

        /// <summary>
        /// 用户昵称，如果昵称为中文，请使用UTF-8字符集对昵称进行URL编码。
        /// </summary>
        public string Nick { get; set; }

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.user.get";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("fields", this.Fields);
            parameters.Add("nick", this.Nick);
            return parameters;
        }

        #endregion
    }
}
