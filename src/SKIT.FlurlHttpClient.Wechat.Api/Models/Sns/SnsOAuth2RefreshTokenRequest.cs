﻿using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [GET] /sns/oauth2/refresh_token 接口的请求。</para>
    /// </summary>
    public class SnsOAuth2RefreshTokenRequest : WechatApiRequest
    {
        /// <summary>
        /// <i>（使用默认值即可，无需修改）</i>
        /// </summary>
        public string GrantType { get; set; } = "refresh_token";

        /// <summary>
        /// 获取或设置通过 AccessToken 获取到的 RefreshToken 参数。
        /// </summary>
        public string RefreshToken { get; set; } = string.Empty;
    }
}