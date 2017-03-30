﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AspNetCore.Weixin
{
    /// <summary>
    /// 订阅事件。或，用户扫描带参数（场景值）二维码（扫描前未关注）。
    /// </summary>
    public class SubscribeEventReceivedEventArgs : EventReceivedEventArgs
    {
        #region 用户扫描带参数（场景值）二维码（扫描前未关注）
        /// <summary>
        /// 事件KEY值，qrscene_为前缀，后面为二维码的参数值
        /// </summary>
        public string EventKey { get; set; }

        /// <summary>
        /// 二维码的ticket，可用来换取二维码图片
        /// </summary>
        public string Ticket { get; set; }
        #endregion
    }
}
