// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: GetFriendChallengeLineupScRsp.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from GetFriendChallengeLineupScRsp.proto</summary>
  public static partial class GetFriendChallengeLineupScRspReflection {

    #region Descriptor
    /// <summary>File descriptor for GetFriendChallengeLineupScRsp.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static GetFriendChallengeLineupScRspReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiNHZXRGcmllbmRDaGFsbGVuZ2VMaW5ldXBTY1JzcC5wcm90bxoRSEdITUtN",
            "Q0VBS0gucHJvdG8iaAodR2V0RnJpZW5kQ2hhbGxlbmdlTGluZXVwU2NSc3AS",
            "DwoHcmV0Y29kZRgNIAEoDRITCgtFRUhMTkRHSkNITRgLIAEoCBIhCgtOTUlH",
            "R0RLRE9EShgBIAMoCzIMLkhHSE1LTUNFQUtIQh6qAhtFZ2dMaW5rLkRhbmhl",
            "bmdTZXJ2ZXIuUHJvdG9iBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::EggLink.DanhengServer.Proto.HGHMKMCEAKHReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.GetFriendChallengeLineupScRsp), global::EggLink.DanhengServer.Proto.GetFriendChallengeLineupScRsp.Parser, new[]{ "Retcode", "EEHLNDGJCHM", "NMIGGDKDODJ" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class GetFriendChallengeLineupScRsp : pb::IMessage<GetFriendChallengeLineupScRsp>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<GetFriendChallengeLineupScRsp> _parser = new pb::MessageParser<GetFriendChallengeLineupScRsp>(() => new GetFriendChallengeLineupScRsp());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<GetFriendChallengeLineupScRsp> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.GetFriendChallengeLineupScRspReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GetFriendChallengeLineupScRsp() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GetFriendChallengeLineupScRsp(GetFriendChallengeLineupScRsp other) : this() {
      retcode_ = other.retcode_;
      eEHLNDGJCHM_ = other.eEHLNDGJCHM_;
      nMIGGDKDODJ_ = other.nMIGGDKDODJ_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GetFriendChallengeLineupScRsp Clone() {
      return new GetFriendChallengeLineupScRsp(this);
    }

    /// <summary>Field number for the "retcode" field.</summary>
    public const int RetcodeFieldNumber = 13;
    private uint retcode_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Retcode {
      get { return retcode_; }
      set {
        retcode_ = value;
      }
    }

    /// <summary>Field number for the "EEHLNDGJCHM" field.</summary>
    public const int EEHLNDGJCHMFieldNumber = 11;
    private bool eEHLNDGJCHM_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool EEHLNDGJCHM {
      get { return eEHLNDGJCHM_; }
      set {
        eEHLNDGJCHM_ = value;
      }
    }

    /// <summary>Field number for the "NMIGGDKDODJ" field.</summary>
    public const int NMIGGDKDODJFieldNumber = 1;
    private static readonly pb::FieldCodec<global::EggLink.DanhengServer.Proto.HGHMKMCEAKH> _repeated_nMIGGDKDODJ_codec
        = pb::FieldCodec.ForMessage(10, global::EggLink.DanhengServer.Proto.HGHMKMCEAKH.Parser);
    private readonly pbc::RepeatedField<global::EggLink.DanhengServer.Proto.HGHMKMCEAKH> nMIGGDKDODJ_ = new pbc::RepeatedField<global::EggLink.DanhengServer.Proto.HGHMKMCEAKH>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::EggLink.DanhengServer.Proto.HGHMKMCEAKH> NMIGGDKDODJ {
      get { return nMIGGDKDODJ_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as GetFriendChallengeLineupScRsp);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(GetFriendChallengeLineupScRsp other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Retcode != other.Retcode) return false;
      if (EEHLNDGJCHM != other.EEHLNDGJCHM) return false;
      if(!nMIGGDKDODJ_.Equals(other.nMIGGDKDODJ_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (Retcode != 0) hash ^= Retcode.GetHashCode();
      if (EEHLNDGJCHM != false) hash ^= EEHLNDGJCHM.GetHashCode();
      hash ^= nMIGGDKDODJ_.GetHashCode();
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
      nMIGGDKDODJ_.WriteTo(output, _repeated_nMIGGDKDODJ_codec);
      if (EEHLNDGJCHM != false) {
        output.WriteRawTag(88);
        output.WriteBool(EEHLNDGJCHM);
      }
      if (Retcode != 0) {
        output.WriteRawTag(104);
        output.WriteUInt32(Retcode);
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
      nMIGGDKDODJ_.WriteTo(ref output, _repeated_nMIGGDKDODJ_codec);
      if (EEHLNDGJCHM != false) {
        output.WriteRawTag(88);
        output.WriteBool(EEHLNDGJCHM);
      }
      if (Retcode != 0) {
        output.WriteRawTag(104);
        output.WriteUInt32(Retcode);
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
      if (Retcode != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Retcode);
      }
      if (EEHLNDGJCHM != false) {
        size += 1 + 1;
      }
      size += nMIGGDKDODJ_.CalculateSize(_repeated_nMIGGDKDODJ_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(GetFriendChallengeLineupScRsp other) {
      if (other == null) {
        return;
      }
      if (other.Retcode != 0) {
        Retcode = other.Retcode;
      }
      if (other.EEHLNDGJCHM != false) {
        EEHLNDGJCHM = other.EEHLNDGJCHM;
      }
      nMIGGDKDODJ_.Add(other.nMIGGDKDODJ_);
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
          case 10: {
            nMIGGDKDODJ_.AddEntriesFrom(input, _repeated_nMIGGDKDODJ_codec);
            break;
          }
          case 88: {
            EEHLNDGJCHM = input.ReadBool();
            break;
          }
          case 104: {
            Retcode = input.ReadUInt32();
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
          case 10: {
            nMIGGDKDODJ_.AddEntriesFrom(ref input, _repeated_nMIGGDKDODJ_codec);
            break;
          }
          case 88: {
            EEHLNDGJCHM = input.ReadBool();
            break;
          }
          case 104: {
            Retcode = input.ReadUInt32();
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