// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: RogueTournBattleFailSettleInfoScNotify.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from RogueTournBattleFailSettleInfoScNotify.proto</summary>
  public static partial class RogueTournBattleFailSettleInfoScNotifyReflection {

    #region Descriptor
    /// <summary>File descriptor for RogueTournBattleFailSettleInfoScNotify.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static RogueTournBattleFailSettleInfoScNotifyReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CixSb2d1ZVRvdXJuQmF0dGxlRmFpbFNldHRsZUluZm9TY05vdGlmeS5wcm90",
            "bxoRQUFGSEdHSENOTE8ucHJvdG8aHFJvZ3VlVG91cm5DdXJTY2VuZUluZm8u",
            "cHJvdG8iiAEKJlJvZ3VlVG91cm5CYXR0bGVGYWlsU2V0dGxlSW5mb1NjTm90",
            "aWZ5EiEKC0lPTEZET0lQTktBGA4gASgLMgwuQUFGSEdHSENOTE8SOwoacm9n",
            "dWVfdG91cm5fY3VyX3NjZW5lX2luZm8YCyABKAsyFy5Sb2d1ZVRvdXJuQ3Vy",
            "U2NlbmVJbmZvQh6qAhtFZ2dMaW5rLkRhbmhlbmdTZXJ2ZXIuUHJvdG9iBnBy",
            "b3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::EggLink.DanhengServer.Proto.AAFHGGHCNLOReflection.Descriptor, global::EggLink.DanhengServer.Proto.RogueTournCurSceneInfoReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.RogueTournBattleFailSettleInfoScNotify), global::EggLink.DanhengServer.Proto.RogueTournBattleFailSettleInfoScNotify.Parser, new[]{ "IOLFDOIPNKA", "RogueTournCurSceneInfo" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class RogueTournBattleFailSettleInfoScNotify : pb::IMessage<RogueTournBattleFailSettleInfoScNotify>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<RogueTournBattleFailSettleInfoScNotify> _parser = new pb::MessageParser<RogueTournBattleFailSettleInfoScNotify>(() => new RogueTournBattleFailSettleInfoScNotify());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<RogueTournBattleFailSettleInfoScNotify> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.RogueTournBattleFailSettleInfoScNotifyReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public RogueTournBattleFailSettleInfoScNotify() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public RogueTournBattleFailSettleInfoScNotify(RogueTournBattleFailSettleInfoScNotify other) : this() {
      iOLFDOIPNKA_ = other.iOLFDOIPNKA_ != null ? other.iOLFDOIPNKA_.Clone() : null;
      rogueTournCurSceneInfo_ = other.rogueTournCurSceneInfo_ != null ? other.rogueTournCurSceneInfo_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public RogueTournBattleFailSettleInfoScNotify Clone() {
      return new RogueTournBattleFailSettleInfoScNotify(this);
    }

    /// <summary>Field number for the "IOLFDOIPNKA" field.</summary>
    public const int IOLFDOIPNKAFieldNumber = 14;
    private global::EggLink.DanhengServer.Proto.AAFHGGHCNLO iOLFDOIPNKA_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.AAFHGGHCNLO IOLFDOIPNKA {
      get { return iOLFDOIPNKA_; }
      set {
        iOLFDOIPNKA_ = value;
      }
    }

    /// <summary>Field number for the "rogue_tourn_cur_scene_info" field.</summary>
    public const int RogueTournCurSceneInfoFieldNumber = 11;
    private global::EggLink.DanhengServer.Proto.RogueTournCurSceneInfo rogueTournCurSceneInfo_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.RogueTournCurSceneInfo RogueTournCurSceneInfo {
      get { return rogueTournCurSceneInfo_; }
      set {
        rogueTournCurSceneInfo_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as RogueTournBattleFailSettleInfoScNotify);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(RogueTournBattleFailSettleInfoScNotify other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(IOLFDOIPNKA, other.IOLFDOIPNKA)) return false;
      if (!object.Equals(RogueTournCurSceneInfo, other.RogueTournCurSceneInfo)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (iOLFDOIPNKA_ != null) hash ^= IOLFDOIPNKA.GetHashCode();
      if (rogueTournCurSceneInfo_ != null) hash ^= RogueTournCurSceneInfo.GetHashCode();
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
      if (rogueTournCurSceneInfo_ != null) {
        output.WriteRawTag(90);
        output.WriteMessage(RogueTournCurSceneInfo);
      }
      if (iOLFDOIPNKA_ != null) {
        output.WriteRawTag(114);
        output.WriteMessage(IOLFDOIPNKA);
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
      if (rogueTournCurSceneInfo_ != null) {
        output.WriteRawTag(90);
        output.WriteMessage(RogueTournCurSceneInfo);
      }
      if (iOLFDOIPNKA_ != null) {
        output.WriteRawTag(114);
        output.WriteMessage(IOLFDOIPNKA);
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
      if (iOLFDOIPNKA_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(IOLFDOIPNKA);
      }
      if (rogueTournCurSceneInfo_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(RogueTournCurSceneInfo);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(RogueTournBattleFailSettleInfoScNotify other) {
      if (other == null) {
        return;
      }
      if (other.iOLFDOIPNKA_ != null) {
        if (iOLFDOIPNKA_ == null) {
          IOLFDOIPNKA = new global::EggLink.DanhengServer.Proto.AAFHGGHCNLO();
        }
        IOLFDOIPNKA.MergeFrom(other.IOLFDOIPNKA);
      }
      if (other.rogueTournCurSceneInfo_ != null) {
        if (rogueTournCurSceneInfo_ == null) {
          RogueTournCurSceneInfo = new global::EggLink.DanhengServer.Proto.RogueTournCurSceneInfo();
        }
        RogueTournCurSceneInfo.MergeFrom(other.RogueTournCurSceneInfo);
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
          case 90: {
            if (rogueTournCurSceneInfo_ == null) {
              RogueTournCurSceneInfo = new global::EggLink.DanhengServer.Proto.RogueTournCurSceneInfo();
            }
            input.ReadMessage(RogueTournCurSceneInfo);
            break;
          }
          case 114: {
            if (iOLFDOIPNKA_ == null) {
              IOLFDOIPNKA = new global::EggLink.DanhengServer.Proto.AAFHGGHCNLO();
            }
            input.ReadMessage(IOLFDOIPNKA);
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
          case 90: {
            if (rogueTournCurSceneInfo_ == null) {
              RogueTournCurSceneInfo = new global::EggLink.DanhengServer.Proto.RogueTournCurSceneInfo();
            }
            input.ReadMessage(RogueTournCurSceneInfo);
            break;
          }
          case 114: {
            if (iOLFDOIPNKA_ == null) {
              IOLFDOIPNKA = new global::EggLink.DanhengServer.Proto.AAFHGGHCNLO();
            }
            input.ReadMessage(IOLFDOIPNKA);
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