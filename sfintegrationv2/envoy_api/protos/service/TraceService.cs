// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: trace/v2/trace_service.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Envoy.Service.Trace.V2 {

  /// <summary>Holder for reflection information generated from trace/v2/trace_service.proto</summary>
  public static partial class TraceServiceReflection {

    #region Descriptor
    /// <summary>File descriptor for trace/v2/trace_service.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static TraceServiceReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Chx0cmFjZS92Mi90cmFjZV9zZXJ2aWNlLnByb3RvEhZlbnZveS5zZXJ2aWNl",
            "LnRyYWNlLnYyGhxlbnZveS9hcGkvdjIvY29yZS9iYXNlLnByb3RvGgt0cmFj",
            "ZS5wcm90bxocZ29vZ2xlL2FwaS9hbm5vdGF0aW9ucy5wcm90bxoXdmFsaWRh",
            "dGUvdmFsaWRhdGUucHJvdG8iFgoUU3RyZWFtVHJhY2VzUmVzcG9uc2UizwEK",
            "E1N0cmVhbVRyYWNlc01lc3NhZ2USSgoKaWRlbnRpZmllchgBIAEoCzI2LmVu",
            "dm95LnNlcnZpY2UudHJhY2UudjIuU3RyZWFtVHJhY2VzTWVzc2FnZS5JZGVu",
            "dGlmaWVyEisKBXNwYW5zGAIgAygLMhwub3BlbmNlbnN1cy5wcm90by50cmFj",
            "ZS5TcGFuGj8KCklkZW50aWZpZXISMQoEbm9kZRgBIAEoCzIXLmVudm95LmFw",
            "aS52Mi5jb3JlLk5vZGVCCrrpwAMFigECEAEyfQoMVHJhY2VTZXJ2aWNlEm0K",
            "DFN0cmVhbVRyYWNlcxIrLmVudm95LnNlcnZpY2UudHJhY2UudjIuU3RyZWFt",
            "VHJhY2VzTWVzc2FnZRosLmVudm95LnNlcnZpY2UudHJhY2UudjIuU3RyZWFt",
            "VHJhY2VzUmVzcG9uc2UiACgBQgRaAnYyYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Envoy.Api.V2.Core.BaseReflection.Descriptor, global::Opencensus.Proto.Trace.TraceReflection.Descriptor, global::Google.Api.AnnotationsReflection.Descriptor, global::Validate.ValidateReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Envoy.Service.Trace.V2.StreamTracesResponse), global::Envoy.Service.Trace.V2.StreamTracesResponse.Parser, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Envoy.Service.Trace.V2.StreamTracesMessage), global::Envoy.Service.Trace.V2.StreamTracesMessage.Parser, new[]{ "Identifier", "Spans" }, null, null, new pbr::GeneratedClrTypeInfo[] { new pbr::GeneratedClrTypeInfo(typeof(global::Envoy.Service.Trace.V2.StreamTracesMessage.Types.Identifier), global::Envoy.Service.Trace.V2.StreamTracesMessage.Types.Identifier.Parser, new[]{ "Node" }, null, null, null)})
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class StreamTracesResponse : pb::IMessage<StreamTracesResponse> {
    private static readonly pb::MessageParser<StreamTracesResponse> _parser = new pb::MessageParser<StreamTracesResponse>(() => new StreamTracesResponse());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<StreamTracesResponse> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Envoy.Service.Trace.V2.TraceServiceReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public StreamTracesResponse() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public StreamTracesResponse(StreamTracesResponse other) : this() {
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public StreamTracesResponse Clone() {
      return new StreamTracesResponse(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as StreamTracesResponse);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(StreamTracesResponse other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(StreamTracesResponse other) {
      if (other == null) {
        return;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
        }
      }
    }

  }

  public sealed partial class StreamTracesMessage : pb::IMessage<StreamTracesMessage> {
    private static readonly pb::MessageParser<StreamTracesMessage> _parser = new pb::MessageParser<StreamTracesMessage>(() => new StreamTracesMessage());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<StreamTracesMessage> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Envoy.Service.Trace.V2.TraceServiceReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public StreamTracesMessage() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public StreamTracesMessage(StreamTracesMessage other) : this() {
      Identifier = other.identifier_ != null ? other.Identifier.Clone() : null;
      spans_ = other.spans_.Clone();
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public StreamTracesMessage Clone() {
      return new StreamTracesMessage(this);
    }

    /// <summary>Field number for the "identifier" field.</summary>
    public const int IdentifierFieldNumber = 1;
    private global::Envoy.Service.Trace.V2.StreamTracesMessage.Types.Identifier identifier_;
    /// <summary>
    /// Identifier data effectively is a structured metadata.
    /// As a performance optimization this will only be sent in the first message
    /// on the stream.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Envoy.Service.Trace.V2.StreamTracesMessage.Types.Identifier Identifier {
      get { return identifier_; }
      set {
        identifier_ = value;
      }
    }

    /// <summary>Field number for the "spans" field.</summary>
    public const int SpansFieldNumber = 2;
    private static readonly pb::FieldCodec<global::Opencensus.Proto.Trace.Span> _repeated_spans_codec
        = pb::FieldCodec.ForMessage(18, global::Opencensus.Proto.Trace.Span.Parser);
    private readonly pbc::RepeatedField<global::Opencensus.Proto.Trace.Span> spans_ = new pbc::RepeatedField<global::Opencensus.Proto.Trace.Span>();
    /// <summary>
    /// A list of Span entries
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::Opencensus.Proto.Trace.Span> Spans {
      get { return spans_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as StreamTracesMessage);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(StreamTracesMessage other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(Identifier, other.Identifier)) return false;
      if(!spans_.Equals(other.spans_)) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (identifier_ != null) hash ^= Identifier.GetHashCode();
      hash ^= spans_.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (identifier_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(Identifier);
      }
      spans_.WriteTo(output, _repeated_spans_codec);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (identifier_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Identifier);
      }
      size += spans_.CalculateSize(_repeated_spans_codec);
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(StreamTracesMessage other) {
      if (other == null) {
        return;
      }
      if (other.identifier_ != null) {
        if (identifier_ == null) {
          identifier_ = new global::Envoy.Service.Trace.V2.StreamTracesMessage.Types.Identifier();
        }
        Identifier.MergeFrom(other.Identifier);
      }
      spans_.Add(other.spans_);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 10: {
            if (identifier_ == null) {
              identifier_ = new global::Envoy.Service.Trace.V2.StreamTracesMessage.Types.Identifier();
            }
            input.ReadMessage(identifier_);
            break;
          }
          case 18: {
            spans_.AddEntriesFrom(input, _repeated_spans_codec);
            break;
          }
        }
      }
    }

    #region Nested types
    /// <summary>Container for nested types declared in the StreamTracesMessage message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static partial class Types {
      public sealed partial class Identifier : pb::IMessage<Identifier> {
        private static readonly pb::MessageParser<Identifier> _parser = new pb::MessageParser<Identifier>(() => new Identifier());
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public static pb::MessageParser<Identifier> Parser { get { return _parser; } }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public static pbr::MessageDescriptor Descriptor {
          get { return global::Envoy.Service.Trace.V2.StreamTracesMessage.Descriptor.NestedTypes[0]; }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        pbr::MessageDescriptor pb::IMessage.Descriptor {
          get { return Descriptor; }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public Identifier() {
          OnConstruction();
        }

        partial void OnConstruction();

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public Identifier(Identifier other) : this() {
          Node = other.node_ != null ? other.Node.Clone() : null;
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public Identifier Clone() {
          return new Identifier(this);
        }

        /// <summary>Field number for the "node" field.</summary>
        public const int NodeFieldNumber = 1;
        private global::Envoy.Api.V2.Core.Node node_;
        /// <summary>
        /// The node sending the access log messages over the stream.
        /// </summary>
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public global::Envoy.Api.V2.Core.Node Node {
          get { return node_; }
          set {
            node_ = value;
          }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public override bool Equals(object other) {
          return Equals(other as Identifier);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public bool Equals(Identifier other) {
          if (ReferenceEquals(other, null)) {
            return false;
          }
          if (ReferenceEquals(other, this)) {
            return true;
          }
          if (!object.Equals(Node, other.Node)) return false;
          return true;
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public override int GetHashCode() {
          int hash = 1;
          if (node_ != null) hash ^= Node.GetHashCode();
          return hash;
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public override string ToString() {
          return pb::JsonFormatter.ToDiagnosticString(this);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public void WriteTo(pb::CodedOutputStream output) {
          if (node_ != null) {
            output.WriteRawTag(10);
            output.WriteMessage(Node);
          }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public int CalculateSize() {
          int size = 0;
          if (node_ != null) {
            size += 1 + pb::CodedOutputStream.ComputeMessageSize(Node);
          }
          return size;
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public void MergeFrom(Identifier other) {
          if (other == null) {
            return;
          }
          if (other.node_ != null) {
            if (node_ == null) {
              node_ = new global::Envoy.Api.V2.Core.Node();
            }
            Node.MergeFrom(other.Node);
          }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public void MergeFrom(pb::CodedInputStream input) {
          uint tag;
          while ((tag = input.ReadTag()) != 0) {
            switch(tag) {
              default:
                input.SkipLastField();
                break;
              case 10: {
                if (node_ == null) {
                  node_ = new global::Envoy.Api.V2.Core.Node();
                }
                input.ReadMessage(node_);
                break;
              }
            }
          }
        }

      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code