﻿using System;
using System.IO;
using System.Text.Json;

namespace SKIT.FlurlHttpClient.Wechat.Api.UnitTests
{
    class TestConfigs
    {
        static TestConfigs()
        {
            // NOTICE: 请在项目根目录下建立 appsettings.local.json，按照 appsettings.json 的格式填入测试参数。
            // WARN: 敏感信息请不要提交到 git！

            using var stream = File.OpenRead("appsettings.local.json");
            using var json = JsonDocument.Parse(stream);
            var config = json.RootElement.GetProperty("WechatConfig");
            WechatAppId = config.GetProperty("AppId").GetString();
            WechatAppSecret = config.GetProperty("AppSecret").GetString();
            WechatAccessToken = config.GetProperty("AccessToken").GetString();
            WechatOpenId = config.GetProperty("OpenId").GetString();
        }

        public static readonly string WechatAppId;
        public static readonly string WechatAppSecret;
        public static readonly string WechatAccessToken;
        public static readonly string WechatOpenId;
    }
}