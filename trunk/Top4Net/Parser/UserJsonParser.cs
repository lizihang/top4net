﻿using System;

using Taobao.Top.Api.Domain;

using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Taobao.Top.Api.Parser
{
    /// <summary>
    /// TOP API: taobao.user.get的JSON响应解释器。
    /// </summary>
    public class UserJsonParser : ITopParser<User>
    {
        #region ITopParser<User> Members

        public User Parse(string body)
        {
            User user = null;

            JObject jsonBody = JObject.Parse(body);
            JArray jsonUsers = jsonBody["rsp"]["users"] as JArray;

            if (jsonUsers != null && jsonUsers.Count > 0)
            {
                JsonSerializer js = new JsonSerializer();
                user = js.Deserialize(jsonUsers[0].CreateReader(), typeof(User)) as User;
            }

            return user;
        }

        #endregion
    }
}
