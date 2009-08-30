﻿using System;
using Taobao.Top.Api.Domain;

namespace Taobao.Top.Api.Parser
{
    /// <summary>
    /// 物流公司列表的JSON响应解释器。
    /// </summary>
    public class LogisticsCompanyListJsonParser : ITopParser<ResponseList<LogisticsCompany>>
    {
        #region ITopParser<ResponseList<LogisticsCompany>> Members

        public ResponseList<LogisticsCompany> Parse(string body)
        {
            return ResponseList<LogisticsCompany>.ParseJsonResponse("logistic_companies", body);
        }

        #endregion
    }

    /// <summary>
    /// 物流公司的JSON响应解释器。
    /// </summary>
    public class LogisticsCompanyJsonParser : ITopParser<LogisticsCompany>
    {
        #region ITopParser<LogisticsCompany> Members

        public LogisticsCompany Parse(string body)
        {
            LogisticsCompanyListJsonParser parser = new LogisticsCompanyListJsonParser();
            return parser.Parse(body).GetFirst();
        }

        #endregion
    }

    /// <summary>
    /// 地址区域列表的JSON响应解释器。
    /// </summary>
    public class AreaListJsonParser : ITopParser<ResponseList<Area>>
    {
        #region ITopParser<ResponseList<Area>> Members

        public ResponseList<Area> Parse(string body)
        {
            return ResponseList<Area>.ParseJsonResponse("areas", body);
        }

        #endregion
    }

    /// <summary>
    /// 地址区域的JSON响应解释器。
    /// </summary>
    public class AreaJsonParser : ITopParser<Area>
    {
        #region ITopParser<Area> Members

        public Area Parse(string body)
        {
            AreaListJsonParser parser = new AreaListJsonParser();
            return parser.Parse(body).GetFirst();
        }

        #endregion
    }
}
