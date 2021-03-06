﻿using Newtonsoft.Json;
using System;

namespace LightMessager.Message
{
    public class BaseMessage
    {
        internal long MsgHash { set; get; }

        /// <summary>
        ///message唯一值，必须唯一，否则等于消息重发 
        /// </summary>
        [JsonIgnore]
        public string Source { set; get; }

        [JsonIgnore]
        internal bool NeedNAck { set; get; }

        /// <summary>
        /// publisher -> broker
        /// </summary>
        internal int RetryCount_Publish { set; get; }

        /// <summary>
        /// broker -> consumer
        /// </summary>
        internal int RetryCount_Deliver { set; get; }

        internal DateTime LastRetryTime { set; get; }

        [JsonIgnore]
        internal string Pattern { set; get; }

        public DateTime CreatedTime { set; get; }
    }
}
