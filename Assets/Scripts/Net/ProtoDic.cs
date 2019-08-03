
using Google.Protobuf;
using Pb;
using MessageId;
using System;
using System.Collections.Generic;

namespace Proto
{
   public class ProtoDic
   {
       private static List<Message> _protoId = new List<Message>
       {
           Message.SignIn,
        };

      private static List<Type>_protoType = new List<Type>
      {
            typeof(LoginResp),  
       };

       private static readonly Dictionary<RuntimeTypeHandle, MessageParser> Parsers = new Dictionary<RuntimeTypeHandle, MessageParser>()
       {    
            {typeof(LoginResp).TypeHandle,LoginResp.Parser },       
       };

        public static MessageParser GetMessageParser(RuntimeTypeHandle typeHandle)
        {
            MessageParser messageParser;
            Parsers.TryGetValue(typeHandle, out messageParser);
            return messageParser;
        }

        public static Type GetProtoTypeByProtoId(Message protoId)
        {
            int index = _protoId.IndexOf(protoId);
            return _protoType[index];
        }

        public static Message GetProtoIdByProtoType(Type type)
        {
            int index = _protoType.IndexOf(type);
            return _protoId[index];
        }

        public static bool ContainProtoId(Message protoId)
        {
            if(_protoId.Contains(protoId))
            {
                return true;
            }
            return false;
        }

        public static bool ContainProtoType(Type type)
        {
            if(_protoType.Contains(type))
            {
                return true;
            }
            return false;
        }
    }
}