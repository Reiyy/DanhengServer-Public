// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: MessageSection.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from MessageSection.proto</summary>
  public static partial class MessageSectionReflection {

    #region Descriptor
    /// <summary>File descriptor for MessageSection.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static MessageSectionReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChRNZXNzYWdlU2VjdGlvbi5wcm90bxoaTWVzc2FnZVNlY3Rpb25TdGF0dXMu",
            "cHJvdG8aEU1lc3NhZ2VJdGVtLnByb3RvIpgBCg5NZXNzYWdlU2VjdGlvbhIl",
            "CgZzdGF0dXMYASABKA4yFS5NZXNzYWdlU2VjdGlvblN0YXR1cxIKCgJpZBgK",
            "IAEoDRIZChF0b19jaG9vc2VfaXRlbV9pZBgNIAMoDRIXCg9tZXNzYWdlX2l0",
            "ZW1faWQYCSABKA0SHwoJaXRlbV9saXN0GAggAygLMgwuTWVzc2FnZUl0ZW1C",
            "HqoCG0VnZ0xpbmsuRGFuaGVuZ1NlcnZlci5Qcm90b2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::EggLink.DanhengServer.Proto.MessageSectionStatusReflection.Descriptor, global::EggLink.DanhengServer.Proto.MessageItemReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.MessageSection), global::EggLink.DanhengServer.Proto.MessageSection.Parser, new[]{ "Status", "Id", "ToChooseItemId", "MessageItemId", "ItemList" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class MessageSection : pb::IMessage<MessageSection>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<MessageSection> _parser = new pb::MessageParser<MessageSection>(() => new MessageSection());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<MessageSection> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.MessageSectionReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public MessageSection() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public MessageSection(MessageSection other) : this() {
      status_ = other.status_;
      id_ = other.id_;
      toChooseItemId_ = other.toChooseItemId_.Clone();
      messageItemId_ = other.messageItemId_;
      itemList_ = other.itemList_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public MessageSection Clone() {
      return new MessageSection(this);
    }

    /// <summary>Field number for the "status" field.</summary>
    public const int StatusFieldNumber = 1;
    private global::EggLink.DanhengServer.Proto.MessageSectionStatus status_ = global::EggLink.DanhengServer.Proto.MessageSectionStatus.MessageSectionNone;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.MessageSectionStatus Status {
      get { return status_; }
      set {
        status_ = value;
      }
    }

    /// <summary>Field number for the "id" field.</summary>
    public const int IdFieldNumber = 10;
    private uint id_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Id {
      get { return id_; }
      set {
        id_ = value;
      }
    }

    /// <summary>Field number for the "to_choose_item_id" field.</summary>
    public const int ToChooseItemIdFieldNumber = 13;
    private static readonly pb::FieldCodec<uint> _repeated_toChooseItemId_codec
        = pb::FieldCodec.ForUInt32(106);
    private readonly pbc::RepeatedField<uint> toChooseItemId_ = new pbc::RepeatedField<uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<uint> ToChooseItemId {
      get { return toChooseItemId_; }
    }

    /// <summary>Field number for the "message_item_id" field.</summary>
    public const int MessageItemIdFieldNumber = 9;
    private uint messageItemId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint MessageItemId {
      get { return messageItemId_; }
      set {
        messageItemId_ = value;
      }
    }

    /// <summary>Field number for the "item_list" field.</summary>
    public const int ItemListFieldNumber = 8;
    private static readonly pb::FieldCodec<global::EggLink.DanhengServer.Proto.MessageItem> _repeated_itemList_codec
        = pb::FieldCodec.ForMessage(66, global::EggLink.DanhengServer.Proto.MessageItem.Parser);
    private readonly pbc::RepeatedField<global::EggLink.DanhengServer.Proto.MessageItem> itemList_ = new pbc::RepeatedField<global::EggLink.DanhengServer.Proto.MessageItem>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::EggLink.DanhengServer.Proto.MessageItem> ItemList {
      get { return itemList_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as MessageSection);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(MessageSection other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Status != other.Status) return false;
      if (Id != other.Id) return false;
      if(!toChooseItemId_.Equals(other.toChooseItemId_)) return false;
      if (MessageItemId != other.MessageItemId) return false;
      if(!itemList_.Equals(other.itemList_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (Status != global::EggLink.DanhengServer.Proto.MessageSectionStatus.MessageSectionNone) hash ^= Status.GetHashCode();
      if (Id != 0) hash ^= Id.GetHashCode();
      hash ^= toChooseItemId_.GetHashCode();
      if (MessageItemId != 0) hash ^= MessageItemId.GetHashCode();
      hash ^= itemList_.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void WriteTo(pb::CodedOutputStream output) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      output.WriteRawMessage(this);
    #else
      if (Status != global::EggLink.DanhengServer.Proto.MessageSectionStatus.MessageSectionNone) {
        output.WriteRawTag(8);
        output.WriteEnum((int) Status);
      }
      itemList_.WriteTo(output, _repeated_itemList_codec);
      if (MessageItemId != 0) {
        output.WriteRawTag(72);
        output.WriteUInt32(MessageItemId);
      }
      if (Id != 0) {
        output.WriteRawTag(80);
        output.WriteUInt32(Id);
      }
      toChooseItemId_.WriteTo(output, _repeated_toChooseItemId_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (Status != global::EggLink.DanhengServer.Proto.MessageSectionStatus.MessageSectionNone) {
        output.WriteRawTag(8);
        output.WriteEnum((int) Status);
      }
      itemList_.WriteTo(ref output, _repeated_itemList_codec);
      if (MessageItemId != 0) {
        output.WriteRawTag(72);
        output.WriteUInt32(MessageItemId);
      }
      if (Id != 0) {
        output.WriteRawTag(80);
        output.WriteUInt32(Id);
      }
      toChooseItemId_.WriteTo(ref output, _repeated_toChooseItemId_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      if (Status != global::EggLink.DanhengServer.Proto.MessageSectionStatus.MessageSectionNone) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Status);
      }
      if (Id != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Id);
      }
      size += toChooseItemId_.CalculateSize(_repeated_toChooseItemId_codec);
      if (MessageItemId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(MessageItemId);
      }
      size += itemList_.CalculateSize(_repeated_itemList_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(MessageSection other) {
      if (other == null) {
        return;
      }
      if (other.Status != global::EggLink.DanhengServer.Proto.MessageSectionStatus.MessageSectionNone) {
        Status = other.Status;
      }
      if (other.Id != 0) {
        Id = other.Id;
      }
      toChooseItemId_.Add(other.toChooseItemId_);
      if (other.MessageItemId != 0) {
        MessageItemId = other.MessageItemId;
      }
      itemList_.Add(other.itemList_);
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(pb::CodedInputStream input) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      input.ReadRawMessage(this);
    #else
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 8: {
            Status = (global::EggLink.DanhengServer.Proto.MessageSectionStatus) input.ReadEnum();
            break;
          }
          case 66: {
            itemList_.AddEntriesFrom(input, _repeated_itemList_codec);
            break;
          }
          case 72: {
            MessageItemId = input.ReadUInt32();
            break;
          }
          case 80: {
            Id = input.ReadUInt32();
            break;
          }
          case 106:
          case 104: {
            toChooseItemId_.AddEntriesFrom(input, _repeated_toChooseItemId_codec);
            break;
          }
        }
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
            break;
          case 8: {
            Status = (global::EggLink.DanhengServer.Proto.MessageSectionStatus) input.ReadEnum();
            break;
          }
          case 66: {
            itemList_.AddEntriesFrom(ref input, _repeated_itemList_codec);
            break;
          }
          case 72: {
            MessageItemId = input.ReadUInt32();
            break;
          }
          case 80: {
            Id = input.ReadUInt32();
            break;
          }
          case 106:
          case 104: {
            toChooseItemId_.AddEntriesFrom(ref input, _repeated_toChooseItemId_codec);
            break;
          }
        }
      }
    }
    #endif

  }

  #endregion

}

#endregion Designer generated code