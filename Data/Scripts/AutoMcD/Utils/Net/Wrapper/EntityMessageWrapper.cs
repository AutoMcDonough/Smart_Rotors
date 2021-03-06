﻿using ProtoBuf;

// ReSharper disable ExplicitCallerInfoArgument

namespace Sisk.Utils.Net.Wrapper {
    [ProtoContract]
    internal sealed class EntityMessageWrapper : Wrapper {
        [ProtoMember(1)]
        public long EntityId { get; set; }
    }
}