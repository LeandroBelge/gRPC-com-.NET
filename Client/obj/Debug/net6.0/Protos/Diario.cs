// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Protos/diario.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Client {

  /// <summary>Holder for reflection information generated from Protos/diario.proto</summary>
  public static partial class DiarioReflection {

    #region Descriptor
    /// <summary>File descriptor for Protos/diario.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static DiarioReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChNQcm90b3MvZGlhcmlvLnByb3RvEgZkaWFyaW8aH2dvb2dsZS9wcm90b2J1",
            "Zi90aW1lc3RhbXAucHJvdG8iHQoJUmVjdXBlcmFyEhAKCGlkRGlhcmlvGAEg",
            "ASgJIpoBCg5SZXRvcm5hckRpYXJpbxIQCghJZERpYXJpbxgBIAEoBRIVCg1O",
            "b21lUHJvZmVzc29yGAIgASgJEhEKCU5vbWVUdXJtYRgDIAEoCRIXCg9FaERp",
            "YXJpb1JlZ3VsYXIYBCABKAgSMwoPRGF0YVJlY3VwZXJhY2FvGAUgASgLMhou",
            "Z29vZ2xlLnByb3RvYnVmLlRpbWVzdGFtcDJGCgZEaWFyaW8SPAoPUmVjdXBl",
            "cmFyRGlhcmlvEhEuZGlhcmlvLlJlY3VwZXJhchoWLmRpYXJpby5SZXRvcm5h",
            "ckRpYXJpb0IJqgIGQ2xpZW50YgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Protobuf.WellKnownTypes.TimestampReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Client.Recuperar), global::Client.Recuperar.Parser, new[]{ "IdDiario" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Client.RetornarDiario), global::Client.RetornarDiario.Parser, new[]{ "IdDiario", "NomeProfessor", "NomeTurma", "EhDiarioRegular", "DataRecuperacao" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class Recuperar : pb::IMessage<Recuperar>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<Recuperar> _parser = new pb::MessageParser<Recuperar>(() => new Recuperar());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<Recuperar> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Client.DiarioReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Recuperar() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Recuperar(Recuperar other) : this() {
      idDiario_ = other.idDiario_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Recuperar Clone() {
      return new Recuperar(this);
    }

    /// <summary>Field number for the "idDiario" field.</summary>
    public const int IdDiarioFieldNumber = 1;
    private string idDiario_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string IdDiario {
      get { return idDiario_; }
      set {
        idDiario_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as Recuperar);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(Recuperar other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (IdDiario != other.IdDiario) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (IdDiario.Length != 0) hash ^= IdDiario.GetHashCode();
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
      if (IdDiario.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(IdDiario);
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
      if (IdDiario.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(IdDiario);
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
      if (IdDiario.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(IdDiario);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(Recuperar other) {
      if (other == null) {
        return;
      }
      if (other.IdDiario.Length != 0) {
        IdDiario = other.IdDiario;
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
          case 10: {
            IdDiario = input.ReadString();
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
            IdDiario = input.ReadString();
            break;
          }
        }
      }
    }
    #endif

  }

  public sealed partial class RetornarDiario : pb::IMessage<RetornarDiario>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<RetornarDiario> _parser = new pb::MessageParser<RetornarDiario>(() => new RetornarDiario());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<RetornarDiario> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Client.DiarioReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public RetornarDiario() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public RetornarDiario(RetornarDiario other) : this() {
      idDiario_ = other.idDiario_;
      nomeProfessor_ = other.nomeProfessor_;
      nomeTurma_ = other.nomeTurma_;
      ehDiarioRegular_ = other.ehDiarioRegular_;
      dataRecuperacao_ = other.dataRecuperacao_ != null ? other.dataRecuperacao_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public RetornarDiario Clone() {
      return new RetornarDiario(this);
    }

    /// <summary>Field number for the "IdDiario" field.</summary>
    public const int IdDiarioFieldNumber = 1;
    private int idDiario_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int IdDiario {
      get { return idDiario_; }
      set {
        idDiario_ = value;
      }
    }

    /// <summary>Field number for the "NomeProfessor" field.</summary>
    public const int NomeProfessorFieldNumber = 2;
    private string nomeProfessor_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string NomeProfessor {
      get { return nomeProfessor_; }
      set {
        nomeProfessor_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "NomeTurma" field.</summary>
    public const int NomeTurmaFieldNumber = 3;
    private string nomeTurma_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string NomeTurma {
      get { return nomeTurma_; }
      set {
        nomeTurma_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "EhDiarioRegular" field.</summary>
    public const int EhDiarioRegularFieldNumber = 4;
    private bool ehDiarioRegular_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool EhDiarioRegular {
      get { return ehDiarioRegular_; }
      set {
        ehDiarioRegular_ = value;
      }
    }

    /// <summary>Field number for the "DataRecuperacao" field.</summary>
    public const int DataRecuperacaoFieldNumber = 5;
    private global::Google.Protobuf.WellKnownTypes.Timestamp dataRecuperacao_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Google.Protobuf.WellKnownTypes.Timestamp DataRecuperacao {
      get { return dataRecuperacao_; }
      set {
        dataRecuperacao_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as RetornarDiario);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(RetornarDiario other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (IdDiario != other.IdDiario) return false;
      if (NomeProfessor != other.NomeProfessor) return false;
      if (NomeTurma != other.NomeTurma) return false;
      if (EhDiarioRegular != other.EhDiarioRegular) return false;
      if (!object.Equals(DataRecuperacao, other.DataRecuperacao)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (IdDiario != 0) hash ^= IdDiario.GetHashCode();
      if (NomeProfessor.Length != 0) hash ^= NomeProfessor.GetHashCode();
      if (NomeTurma.Length != 0) hash ^= NomeTurma.GetHashCode();
      if (EhDiarioRegular != false) hash ^= EhDiarioRegular.GetHashCode();
      if (dataRecuperacao_ != null) hash ^= DataRecuperacao.GetHashCode();
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
      if (IdDiario != 0) {
        output.WriteRawTag(8);
        output.WriteInt32(IdDiario);
      }
      if (NomeProfessor.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(NomeProfessor);
      }
      if (NomeTurma.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(NomeTurma);
      }
      if (EhDiarioRegular != false) {
        output.WriteRawTag(32);
        output.WriteBool(EhDiarioRegular);
      }
      if (dataRecuperacao_ != null) {
        output.WriteRawTag(42);
        output.WriteMessage(DataRecuperacao);
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
      if (IdDiario != 0) {
        output.WriteRawTag(8);
        output.WriteInt32(IdDiario);
      }
      if (NomeProfessor.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(NomeProfessor);
      }
      if (NomeTurma.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(NomeTurma);
      }
      if (EhDiarioRegular != false) {
        output.WriteRawTag(32);
        output.WriteBool(EhDiarioRegular);
      }
      if (dataRecuperacao_ != null) {
        output.WriteRawTag(42);
        output.WriteMessage(DataRecuperacao);
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
      if (IdDiario != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(IdDiario);
      }
      if (NomeProfessor.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(NomeProfessor);
      }
      if (NomeTurma.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(NomeTurma);
      }
      if (EhDiarioRegular != false) {
        size += 1 + 1;
      }
      if (dataRecuperacao_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(DataRecuperacao);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(RetornarDiario other) {
      if (other == null) {
        return;
      }
      if (other.IdDiario != 0) {
        IdDiario = other.IdDiario;
      }
      if (other.NomeProfessor.Length != 0) {
        NomeProfessor = other.NomeProfessor;
      }
      if (other.NomeTurma.Length != 0) {
        NomeTurma = other.NomeTurma;
      }
      if (other.EhDiarioRegular != false) {
        EhDiarioRegular = other.EhDiarioRegular;
      }
      if (other.dataRecuperacao_ != null) {
        if (dataRecuperacao_ == null) {
          DataRecuperacao = new global::Google.Protobuf.WellKnownTypes.Timestamp();
        }
        DataRecuperacao.MergeFrom(other.DataRecuperacao);
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
          case 8: {
            IdDiario = input.ReadInt32();
            break;
          }
          case 18: {
            NomeProfessor = input.ReadString();
            break;
          }
          case 26: {
            NomeTurma = input.ReadString();
            break;
          }
          case 32: {
            EhDiarioRegular = input.ReadBool();
            break;
          }
          case 42: {
            if (dataRecuperacao_ == null) {
              DataRecuperacao = new global::Google.Protobuf.WellKnownTypes.Timestamp();
            }
            input.ReadMessage(DataRecuperacao);
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
            IdDiario = input.ReadInt32();
            break;
          }
          case 18: {
            NomeProfessor = input.ReadString();
            break;
          }
          case 26: {
            NomeTurma = input.ReadString();
            break;
          }
          case 32: {
            EhDiarioRegular = input.ReadBool();
            break;
          }
          case 42: {
            if (dataRecuperacao_ == null) {
              DataRecuperacao = new global::Google.Protobuf.WellKnownTypes.Timestamp();
            }
            input.ReadMessage(DataRecuperacao);
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