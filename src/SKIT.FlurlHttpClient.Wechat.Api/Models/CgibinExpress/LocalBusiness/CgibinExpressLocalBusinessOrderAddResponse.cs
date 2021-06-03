﻿using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/express/local/business/order/add 接口的响应。</para>
    /// </summary>
    public class CgibinExpressLocalBusinessOrderAddResponse : CgibinExpressLocalBusinessOrderPreAddResponse
    {
        public override bool IsSuccessful()
        {
            return base.IsSuccessful() && ResultCode == 0;
        }
    }
}