// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: PlayerReturnInfoQueryScRsp.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from PlayerReturnInfoQueryScRsp.proto</summary>
  public static partial class PlayerReturnInfoQueryScRspReflection {

    #region Descriptor
    /// <summary>File descriptor for PlayerReturnInfoQueryScRsp.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static PlayerReturnInfoQueryScRspReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiBQbGF5ZXJSZXR1cm5JbmZvUXVlcnlTY1JzcC5wcm90bxoRSEtDRktFRkNH",
            "Q0cucHJvdG8iZQoaUGxheWVyUmV0dXJuSW5mb1F1ZXJ5U2NSc3ASIQoLTkhH",
            "QkxLR0VORkYYDCABKAsyDC5IS0NGS0VGQ0dDRxITCgtDTk9IS0lEQ0VNQxgP",
            "IAEoDRIPCgdyZXRjb2RlGAsgASgNQh6qAhtFZ2dMaW5rLkRhbmhlbmdTZXJ2",
            "ZXIuUHJvdG9iBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::EggLink.DanhengServer.Proto.HKCFKEFCGCGReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.PlayerReturnInfoQueryScRsp), global::EggLink.DanhengServer.Proto.PlayerReturnInfoQueryScRsp.Parser, new[]{ "NHGBLKGENFF", "CNOHKIDCEMC", "Retcode" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class PlayerReturnInfoQueryScRsp : pb::IMessage<PlayerReturnInfoQueryScRsp>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<PlayerReturnInfoQueryScRsp> _parser = new pb::MessageParser<PlayerReturnInfoQueryScRsp>(() => new PlayerReturnInfoQueryScRsp());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<PlayerReturnInfoQueryScRsp> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.PlayerReturnInfoQueryScRspReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public PlayerReturnInfoQueryScRsp() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public PlayerReturnInfoQueryScRsp(PlayerReturnInfoQueryScRsp other) : this() {
      nHGBLKGENFF_ = other.nHGBLKGENFF_ != null ? other.nHGBLKGENFF_.Clone() : null;
      cNOHKIDCEMC_ = other.cNOHKIDCEMC_;
      retcode_ = other.retcode_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public PlayerReturnInfoQueryScRsp Clone() {
      return new PlayerReturnInfoQueryScRsp(this);
    }

    /// <summary>Field number for the "NHGBLKGENFF" field.</summary>
    public const int NHGBLKGENFFFieldNumber = 12;
    private global::EggLink.DanhengServer.Proto.HKCFKEFCGCG nHGBLKGENFF_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.HKCFKEFCGCG NHGBLKGENFF {
      get { return nHGBLKGENFF_; }
      set {
        nHGBLKGENFF_ = value;
      }
    }

    /// <summary>Field number for the "CNOHKIDCEMC" field.</summary>
    public const int CNOHKIDCEMCFieldNumber = 15;
    private uint cNOHKIDCEMC_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint CNOHKIDCEMC {
      get { return cNOHKIDCEMC_; }
      set {
        cNOHKIDCEMC_ = value;
      }
    }

    /// <summary>Field number for the "retcode" field.</summary>
    public const int RetcodeFieldNumber = 11;
    private uint retcode_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Retcode {
      get { return retcode_; }
      set {
        retcode_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as PlayerReturnInfoQueryScRsp);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(PlayerReturnInfoQueryScRsp other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(NHGBLKGENFF, other.NHGBLKGENFF)) return false;
      if (CNOHKIDCEMC != other.CNOHKIDCEMC) return false;
      if (Retcode != other.Retcode) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (nHGBLKGENFF_ != null) hash ^= NHGBLKGENFF.GetHashCode();
      if (CNOHKIDCEMC != 0) hash ^= CNOHKIDCEMC.GetHashCode();
      if (Retcode != 0) hash ^= Retcode.GetHashCode();
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
      if (Retcode != 0) {
        output.WriteRawTag(88);
        output.WriteUInt32(Retcode);
      }
      if (nHGBLKGENFF_ != null) {
        output.WriteRawTag(98);
        output.WriteMessage(NHGBLKGENFF);
      }
      if (CNOHKIDCEMC != 0) {
        output.WriteRawTag(120);
        output.WriteUInt32(CNOHKIDCEMC);
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
      if (Retcode != 0) {
        output.WriteRawTag(88);
        output.WriteUInt32(Retcode);
      }
      if (nHGBLKGENFF_ != null) {
        output.WriteRawTag(98);
        output.WriteMessage(NHGBLKGENFF);
      }
      if (CNOHKIDCEMC != 0) {
        output.WriteRawTag(120);
        output.WriteUInt32(CNOHKIDCEMC);
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
      if (nHGBLKGENFF_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(NHGBLKGENFF);
      }
      if (CNOHKIDCEMC != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(CNOHKIDCEMC);
      }
      if (Retcode != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Retcode);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(PlayerReturnInfoQueryScRsp other) {
      if (other == null) {
        return;
      }
      if (other.nHGBLKGENFF_ != null) {
        if (nHGBLKGENFF_ == null) {
          NHGBLKGENFF = new global::EggLink.DanhengServer.Proto.HKCFKEFCGCG();
        }
        NHGBLKGENFF.MergeFrom(other.NHGBLKGENFF);
      }
      if (other.CNOHKIDCEMC != 0) {
        CNOHKIDCEMC = other.CNOHKIDCEMC;
      }
      if (other.Retcode != 0) {
        Retcode = other.Retcode;
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
          case 88: {
            Retcode = input.ReadUInt32();
            break;
          }
          case 98: {
            if (nHGBLKGENFF_ == null) {
              NHGBLKGENFF = new global::EggLink.DanhengServer.Proto.HKCFKEFCGCG();
            }
            input.ReadMessage(NHGBLKGENFF);
            break;
          }
          case 120: {
            CNOHKIDCEMC = input.ReadUInt32();
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
          case 88: {
            Retcode = input.ReadUInt32();
            break;
          }
          case 98: {
            if (nHGBLKGENFF_ == null) {
              NHGBLKGENFF = new global::EggLink.DanhengServer.Proto.HKCFKEFCGCG();
            }
            input.ReadMessage(NHGBLKGENFF);
            break;
          }
          case 120: {
            CNOHKIDCEMC = input.ReadUInt32();
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