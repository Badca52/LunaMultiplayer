﻿using LunaCommon.Message.Types;

namespace LunaCommon.Message.Data.Handshake
{
    public class HandshakeRequestMsgData : HandshakeBaseMsgData
    {
        /// <inheritdoc />
        internal HandshakeRequestMsgData() { }
        public override HandshakeMessageType HandshakeMessageType => HandshakeMessageType.Request;

        public override string ClassName { get; } = nameof(HandshakeRequestMsgData);
    }
}