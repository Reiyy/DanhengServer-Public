// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: GMPDLOBDFFJ.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from GMPDLOBDFFJ.proto</summary>
  public static partial class GMPDLOBDFFJReflection {

    #region Descriptor
    /// <summary>File descriptor for GMPDLOBDFFJ.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static GMPDLOBDFFJReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChFHTVBETE9CREZGSi5wcm90byJJCgtHTVBETE9CREZGShITCgtNR0hITkhB",
            "RFBHSxgEIAEoDRIQCghldmVudF9pZBgJIAEoDRITCgtMQkxPRENDTE5MSRgN",
            "IAEoDUIeqgIbRWdnTGluay5EYW5oZW5nU2VydmVyLlByb3RvYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.GMPDLOBDFFJ), global::EggLink.DanhengServer.Proto.GMPDLOBDFFJ.Parser, new[]{ "MGHHNHADPGK", "EventId", "LBLODCCLNLI" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class GMPDLOBDFFJ : pb::IMessage<GMPDLOBDFFJ>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<GMPDLOBDFFJ> _parser = new pb::MessageParser<GMPDLOBDFFJ>(() => new GMPDLOBDFFJ());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<GMPDLOBDFFJ> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.GMPDLOBDFFJReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GMPDLOBDFFJ() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GMPDLOBDFFJ(GMPDLOBDFFJ other) : this() {
      mGHHNHADPGK_ = other.mGHHNHADPGK_;
      eventId_ = other.eventId_;
      lBLODCCLNLI_ = other.lBLODCCLNLI_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GMPDLOBDFFJ Clone() {
      return new GMPDLOBDFFJ(this);
    }

    /// <summary>Field number for the "MGHHNHADPGK" field.</summary>
    public const int MGHHNHADPGKFieldNumber = 4;
    private uint mGHHNHADPGK_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint MGHHNHADPGK {
      get { return mGHHNHADPGK_; }
      set {
        mGHHNHADPGK_ = value;
      }
    }

    /// <summary>Field number for the "event_id" field.</summary>
    public const int EventIdFieldNumber = 9;
    private uint eventId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint EventId {
      get { return eventId_; }
      set {
        eventId_ = value;
      }
    }

    /// <summary>Field number for the "LBLODCCLNLI" field.</summary>
    public const int LBLODCCLNLIFieldNumber = 13;
    private uint lBLODCCLNLI_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint LBLODCCLNLI {
      get { return lBLODCCLNLI_; }
      set {
        lBLODCCLNLI_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as GMPDLOBDFFJ);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(GMPDLOBDFFJ other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (MGHHNHADPGK != other.MGHHNHADPGK) return false;
      if (EventId != other.EventId) return false;
      if (LBLODCCLNLI != other.LBLODCCLNLI) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (MGHHNHADPGK != 0) hash ^= MGHHNHADPGK.GetHashCode();
      if (EventId != 0) hash ^= EventId.GetHashCode();
      if (LBLODCCLNLI != 0) hash ^= LBLODCCLNLI.GetHashCode();
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
      if (MGHHNHADPGK != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(MGHHNHADPGK);
      }
      if (EventId != 0) {
        output.WriteRawTag(72);
        output.WriteUInt32(EventId);
      }
      if (LBLODCCLNLI != 0) {
        output.WriteRawTag(104);
        output.WriteUInt32(LBLODCCLNLI);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (MGHHNHADPGK != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(MGHHNHADPGK);
      }
      if (EventId != 0) {
        output.WriteRawTag(72);
        output.WriteUInt32(EventId);
      }
      if (LBLODCCLNLI != 0) {
        output.WriteRawTag(104);
        output.WriteUInt32(LBLODCCLNLI);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      if (MGHHNHADPGK != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(MGHHNHADPGK);
      }
      if (EventId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(EventId);
      }
      if (LBLODCCLNLI != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(LBLODCCLNLI);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(GMPDLOBDFFJ other) {
      if (other == null) {
        return;
      }
      if (other.MGHHNHADPGK != 0) {
        MGHHNHADPGK = other.MGHHNHADPGK;
      }
      if (other.EventId != 0) {
        EventId = other.EventId;
      }
      if (other.LBLODCCLNLI != 0) {
        LBLODCCLNLI = other.LBLODCCLNLI;
      }
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
          case 32: {
            MGHHNHADPGK = input.ReadUInt32();
            break;
          }
          case 72: {
            EventId = input.ReadUInt32();
            break;
          }
          case 104: {
            LBLODCCLNLI = input.ReadUInt32();
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
          case 32: {
            MGHHNHADPGK = input.ReadUInt32();
            break;
          }
          case 72: {
            EventId = input.ReadUInt32();
            break;
          }
          case 104: {
            LBLODCCLNLI = input.ReadUInt32();
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