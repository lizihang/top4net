using System;
using System.Collections.Generic;

namespace Taobao.Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.time.get
    /// </summary>
    public class TimeGetRequest : ITopRequest
    {
        

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.time.get";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            
            return parameters;
        }

        #endregion
    }
}
