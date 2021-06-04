// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Protos/chat.proto
// </auto-generated>
#pragma warning disable 0414, 1591
#region Designer generated code

using grpc = global::Grpc.Core;

namespace GrpcService.Services {
  public static partial class Chat
  {
    static readonly string __ServiceName = "chat.Chat";

    static void __Helper_SerializeMessage(global::Google.Protobuf.IMessage message, grpc::SerializationContext context)
    {
      #if !GRPC_DISABLE_PROTOBUF_BUFFER_SERIALIZATION
      if (message is global::Google.Protobuf.IBufferMessage)
      {
        context.SetPayloadLength(message.CalculateSize());
        global::Google.Protobuf.MessageExtensions.WriteTo(message, context.GetBufferWriter());
        context.Complete();
        return;
      }
      #endif
      context.Complete(global::Google.Protobuf.MessageExtensions.ToByteArray(message));
    }

    static class __Helper_MessageCache<T>
    {
      public static readonly bool IsBufferMessage = global::System.Reflection.IntrospectionExtensions.GetTypeInfo(typeof(global::Google.Protobuf.IBufferMessage)).IsAssignableFrom(typeof(T));
    }

    static T __Helper_DeserializeMessage<T>(grpc::DeserializationContext context, global::Google.Protobuf.MessageParser<T> parser) where T : global::Google.Protobuf.IMessage<T>
    {
      #if !GRPC_DISABLE_PROTOBUF_BUFFER_SERIALIZATION
      if (__Helper_MessageCache<T>.IsBufferMessage)
      {
        return parser.ParseFrom(context.PayloadAsReadOnlySequence());
      }
      #endif
      return parser.ParseFrom(context.PayloadAsNewBuffer());
    }

    static readonly grpc::Marshaller<global::GrpcService.Services.RequestMessage> __Marshaller_chat_RequestMessage = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::GrpcService.Services.RequestMessage.Parser));
    static readonly grpc::Marshaller<global::GrpcService.Services.ResponseMessage> __Marshaller_chat_ResponseMessage = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::GrpcService.Services.ResponseMessage.Parser));

    static readonly grpc::Method<global::GrpcService.Services.RequestMessage, global::GrpcService.Services.ResponseMessage> __Method_SendMessage = new grpc::Method<global::GrpcService.Services.RequestMessage, global::GrpcService.Services.ResponseMessage>(
        grpc::MethodType.DuplexStreaming,
        __ServiceName,
        "SendMessage",
        __Marshaller_chat_RequestMessage,
        __Marshaller_chat_ResponseMessage);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::GrpcService.Services.ChatReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of Chat</summary>
    [grpc::BindServiceMethod(typeof(Chat), "BindService")]
    public abstract partial class ChatBase
    {
      public virtual global::System.Threading.Tasks.Task SendMessage(grpc::IAsyncStreamReader<global::GrpcService.Services.RequestMessage> requestStream, grpc::IServerStreamWriter<global::GrpcService.Services.ResponseMessage> responseStream, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static grpc::ServerServiceDefinition BindService(ChatBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_SendMessage, serviceImpl.SendMessage).Build();
    }

    /// <summary>Register service method with a service binder with or without implementation. Useful when customizing the  service binding logic.
    /// Note: this method is part of an experimental API that can change or be removed without any prior notice.</summary>
    /// <param name="serviceBinder">Service methods will be bound by calling <c>AddMethod</c> on this object.</param>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static void BindService(grpc::ServiceBinderBase serviceBinder, ChatBase serviceImpl)
    {
      serviceBinder.AddMethod(__Method_SendMessage, serviceImpl == null ? null : new grpc::DuplexStreamingServerMethod<global::GrpcService.Services.RequestMessage, global::GrpcService.Services.ResponseMessage>(serviceImpl.SendMessage));
    }

  }
}
#endregion
