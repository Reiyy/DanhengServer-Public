// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: CCGFCOBHOCJ.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from CCGFCOBHOCJ.proto</summary>
  public static partial class CCGFCOBHOCJReflection {

    #region Descriptor
    /// <summary>File descriptor for CCGFCOBHOCJ.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static CCGFCOBHOCJReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChFDQ0dGQ09CSE9DSi5wcm90byI3CgtDQ0dGQ09CSE9DShITCgtLQUJHQU5M",
            "UFBGSBgCIAEoDRITCgtQQUJHSlBFSE5BSBgKIAEoDUIeqgIbRWdnTGluay5E",
            "YW5oZW5nU2VydmVyLlByb3RvYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.CCGFCOBHOCJ), global::EggLink.DanhengServer.Proto.CCGFCOBHOCJ.Parser, new[]{ "KABGANLPPFH", "PABGJPEHNAH" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class CCGFCOBHOCJ : pb::IMessage<CCGFCOBHOCJ>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<CCGFCOBHOCJ> _parser = new pb::MessageParser<CCGFCOBHOCJ>(() => new CCGFCOBHOCJ());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<CCGFCOBHOCJ> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.CCGFCOBHOCJReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public CCGFCOBHOCJ() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public CCGFCOBHOCJ(CCGFCOBHOCJ other) : this() {
      kABGANLPPFH_ = other.kABGANLPPFH_;
      pABGJPEHNAH_ = other.pABGJPEHNAH_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public CCGFCOBHOCJ Clone() {
      return new CCGFCOBHOCJ(this);
    }

    /// <summary>Field number for the "KABGANLPPFH" field.</summary>
    public const int KABGANLPPFHFieldNumber = 2;
    private uint kABGANLPPFH_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint KABGANLPPFH {
      get { return kABGANLPPFH_; }
      set {
        kABGANLPPFH_ = value;
      }
    }

    /// <summary>Field number for the "PABGJPEHNAH" field.</summary>
    public const int PABGJPEHNAHFieldNumber = 10;
    private uint pABGJPEHNAH_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint PABGJPEHNAH {
      get { return pABGJPEHNAH_; }
      set {
        pABGJPEHNAH_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as CCGFCOBHOCJ);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(CCGFCOBHOCJ other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (KABGANLPPFH != other.KABGANLPPFH) return false;
      if (PABGJPEHNAH != other.PABGJPEHNAH) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (KABGANLPPFH != 0) hash ^= KABGANLPPFH.GetHashCode();
      if (PABGJPEHNAH != 0) hash ^= PABGJPEHNAH.GetHashCode();
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
      if (KABGANLPPFH != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(KABGANLPPFH);
      }
      if (PABGJPEHNAH != 0) {
        output.WriteRawTag(80);
        output.WriteUInt32(PABGJPEHNAH);
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
      if (KABGANLPPFH != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(KABGANLPPFH);
      }
      if (PABGJPEHNAH != 0) {
        output.WriteRawTag(80);
        output.WriteUInt32(PABGJPEHNAH);
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
      if (KABGANLPPFH != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(KABGANLPPFH);
      }
      if (PABGJPEHNAH != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(PABGJPEHNAH);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(CCGFCOBHOCJ other) {
      if (other == null) {
        return;
      }
      if (other.KABGANLPPFH != 0) {
        KABGANLPPFH = other.KABGANLPPFH;
      }
      if (other.PABGJPEHNAH != 0) {
        PABGJPEHNAH = other.PABGJPEHNAH;
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
          case 16: {
            KABGANLPPFH = input.ReadUInt32();
            break;
          }
          case 80: {
            PABGJPEHNAH = input.ReadUInt32();
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
          case 16: {
            KABGANLPPFH = input.ReadUInt32();
            break;
          }
          case 80: {
            PABGJPEHNAH = input.ReadUInt32();
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