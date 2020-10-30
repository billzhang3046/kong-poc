// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Protos/loss.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace GrpcEchoService {

  /// <summary>Holder for reflection information generated from Protos/loss.proto</summary>
  public static partial class LossReflection {

    #region Descriptor
    /// <summary>File descriptor for Protos/loss.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static LossReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChFQcm90b3MvbG9zcy5wcm90bxIEbG9zcyIkChNDb3VudEludGVnZXJSZXF1",
            "ZXN0Eg0KBWNvdW50GAEgASgFIicKFENvdW50SW50ZWdlclJlc3BvbnNlEg8K",
            "B251bWJlcnMYASADKAUiJwoQR2V0UmVzdWx0UmVxdWVzdBITCgthbmFseXNp",
            "c1NpZBgBIAEoBSJQChZHZXRFdmVudFJlc3VsdFJlc3BvbnNlEhMKC2FuYWx5",
            "c2lzU2lkGAEgASgFEiEKBnJlc3VsdBgCIAMoCzIRLmxvc3MuRXZlbnRSZXN1",
            "bHQinQEKC0V2ZW50UmVzdWx0EhEKCW1vZGVsQ29kZRgBIAEoBRIUCgxwZXJp",
            "bFNldENvZGUYAiABKAUSDgoGeWVhcklkGAMgASgFEg8KB2V2ZW50SWQYBCAB",
            "KAUSEAoIZ3JvdW5kVXAYBSABKAESDQoFZ3Jvc3MYBiABKAESEAoIcmV0YWlu",
            "ZWQYByABKAESEQoJcHJlQ2F0TmV0GAggASgBMpkBCgRMb3NzEkgKDkdldEV2",
            "ZW50UmVzdWx0EhYubG9zcy5HZXRSZXN1bHRSZXF1ZXN0GhwubG9zcy5HZXRF",
            "dmVudFJlc3VsdFJlc3BvbnNlIgASRwoMQ291bnRJbnRlZ2VyEhkubG9zcy5D",
            "b3VudEludGVnZXJSZXF1ZXN0GhoubG9zcy5Db3VudEludGVnZXJSZXNwb25z",
            "ZSIAQhKqAg9HcnBjRWNob1NlcnZpY2ViBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::GrpcEchoService.CountIntegerRequest), global::GrpcEchoService.CountIntegerRequest.Parser, new[]{ "Count" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::GrpcEchoService.CountIntegerResponse), global::GrpcEchoService.CountIntegerResponse.Parser, new[]{ "Numbers" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::GrpcEchoService.GetResultRequest), global::GrpcEchoService.GetResultRequest.Parser, new[]{ "AnalysisSid" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::GrpcEchoService.GetEventResultResponse), global::GrpcEchoService.GetEventResultResponse.Parser, new[]{ "AnalysisSid", "Result" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::GrpcEchoService.EventResult), global::GrpcEchoService.EventResult.Parser, new[]{ "ModelCode", "PerilSetCode", "YearId", "EventId", "GroundUp", "Gross", "Retained", "PreCatNet" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class CountIntegerRequest : pb::IMessage<CountIntegerRequest> {
    private static readonly pb::MessageParser<CountIntegerRequest> _parser = new pb::MessageParser<CountIntegerRequest>(() => new CountIntegerRequest());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<CountIntegerRequest> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::GrpcEchoService.LossReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CountIntegerRequest() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CountIntegerRequest(CountIntegerRequest other) : this() {
      count_ = other.count_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CountIntegerRequest Clone() {
      return new CountIntegerRequest(this);
    }

    /// <summary>Field number for the "count" field.</summary>
    public const int CountFieldNumber = 1;
    private int count_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int Count {
      get { return count_; }
      set {
        count_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as CountIntegerRequest);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(CountIntegerRequest other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Count != other.Count) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Count != 0) hash ^= Count.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (Count != 0) {
        output.WriteRawTag(8);
        output.WriteInt32(Count);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Count != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Count);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(CountIntegerRequest other) {
      if (other == null) {
        return;
      }
      if (other.Count != 0) {
        Count = other.Count;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 8: {
            Count = input.ReadInt32();
            break;
          }
        }
      }
    }

  }

  public sealed partial class CountIntegerResponse : pb::IMessage<CountIntegerResponse> {
    private static readonly pb::MessageParser<CountIntegerResponse> _parser = new pb::MessageParser<CountIntegerResponse>(() => new CountIntegerResponse());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<CountIntegerResponse> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::GrpcEchoService.LossReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CountIntegerResponse() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CountIntegerResponse(CountIntegerResponse other) : this() {
      numbers_ = other.numbers_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CountIntegerResponse Clone() {
      return new CountIntegerResponse(this);
    }

    /// <summary>Field number for the "numbers" field.</summary>
    public const int NumbersFieldNumber = 1;
    private static readonly pb::FieldCodec<int> _repeated_numbers_codec
        = pb::FieldCodec.ForInt32(10);
    private readonly pbc::RepeatedField<int> numbers_ = new pbc::RepeatedField<int>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<int> Numbers {
      get { return numbers_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as CountIntegerResponse);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(CountIntegerResponse other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!numbers_.Equals(other.numbers_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= numbers_.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      numbers_.WriteTo(output, _repeated_numbers_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      size += numbers_.CalculateSize(_repeated_numbers_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(CountIntegerResponse other) {
      if (other == null) {
        return;
      }
      numbers_.Add(other.numbers_);
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10:
          case 8: {
            numbers_.AddEntriesFrom(input, _repeated_numbers_codec);
            break;
          }
        }
      }
    }

  }

  /// <summary>
  /// The request message containing the user's name.
  /// </summary>
  public sealed partial class GetResultRequest : pb::IMessage<GetResultRequest> {
    private static readonly pb::MessageParser<GetResultRequest> _parser = new pb::MessageParser<GetResultRequest>(() => new GetResultRequest());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<GetResultRequest> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::GrpcEchoService.LossReflection.Descriptor.MessageTypes[2]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GetResultRequest() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GetResultRequest(GetResultRequest other) : this() {
      analysisSid_ = other.analysisSid_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GetResultRequest Clone() {
      return new GetResultRequest(this);
    }

    /// <summary>Field number for the "analysisSid" field.</summary>
    public const int AnalysisSidFieldNumber = 1;
    private int analysisSid_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int AnalysisSid {
      get { return analysisSid_; }
      set {
        analysisSid_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as GetResultRequest);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(GetResultRequest other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (AnalysisSid != other.AnalysisSid) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (AnalysisSid != 0) hash ^= AnalysisSid.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (AnalysisSid != 0) {
        output.WriteRawTag(8);
        output.WriteInt32(AnalysisSid);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (AnalysisSid != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(AnalysisSid);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(GetResultRequest other) {
      if (other == null) {
        return;
      }
      if (other.AnalysisSid != 0) {
        AnalysisSid = other.AnalysisSid;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 8: {
            AnalysisSid = input.ReadInt32();
            break;
          }
        }
      }
    }

  }

  /// <summary>
  /// The response message containing the greetings.
  /// </summary>
  public sealed partial class GetEventResultResponse : pb::IMessage<GetEventResultResponse> {
    private static readonly pb::MessageParser<GetEventResultResponse> _parser = new pb::MessageParser<GetEventResultResponse>(() => new GetEventResultResponse());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<GetEventResultResponse> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::GrpcEchoService.LossReflection.Descriptor.MessageTypes[3]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GetEventResultResponse() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GetEventResultResponse(GetEventResultResponse other) : this() {
      analysisSid_ = other.analysisSid_;
      result_ = other.result_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GetEventResultResponse Clone() {
      return new GetEventResultResponse(this);
    }

    /// <summary>Field number for the "analysisSid" field.</summary>
    public const int AnalysisSidFieldNumber = 1;
    private int analysisSid_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int AnalysisSid {
      get { return analysisSid_; }
      set {
        analysisSid_ = value;
      }
    }

    /// <summary>Field number for the "result" field.</summary>
    public const int ResultFieldNumber = 2;
    private static readonly pb::FieldCodec<global::GrpcEchoService.EventResult> _repeated_result_codec
        = pb::FieldCodec.ForMessage(18, global::GrpcEchoService.EventResult.Parser);
    private readonly pbc::RepeatedField<global::GrpcEchoService.EventResult> result_ = new pbc::RepeatedField<global::GrpcEchoService.EventResult>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::GrpcEchoService.EventResult> Result {
      get { return result_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as GetEventResultResponse);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(GetEventResultResponse other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (AnalysisSid != other.AnalysisSid) return false;
      if(!result_.Equals(other.result_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (AnalysisSid != 0) hash ^= AnalysisSid.GetHashCode();
      hash ^= result_.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (AnalysisSid != 0) {
        output.WriteRawTag(8);
        output.WriteInt32(AnalysisSid);
      }
      result_.WriteTo(output, _repeated_result_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (AnalysisSid != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(AnalysisSid);
      }
      size += result_.CalculateSize(_repeated_result_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(GetEventResultResponse other) {
      if (other == null) {
        return;
      }
      if (other.AnalysisSid != 0) {
        AnalysisSid = other.AnalysisSid;
      }
      result_.Add(other.result_);
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 8: {
            AnalysisSid = input.ReadInt32();
            break;
          }
          case 18: {
            result_.AddEntriesFrom(input, _repeated_result_codec);
            break;
          }
        }
      }
    }

  }

  public sealed partial class EventResult : pb::IMessage<EventResult> {
    private static readonly pb::MessageParser<EventResult> _parser = new pb::MessageParser<EventResult>(() => new EventResult());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<EventResult> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::GrpcEchoService.LossReflection.Descriptor.MessageTypes[4]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public EventResult() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public EventResult(EventResult other) : this() {
      modelCode_ = other.modelCode_;
      perilSetCode_ = other.perilSetCode_;
      yearId_ = other.yearId_;
      eventId_ = other.eventId_;
      groundUp_ = other.groundUp_;
      gross_ = other.gross_;
      retained_ = other.retained_;
      preCatNet_ = other.preCatNet_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public EventResult Clone() {
      return new EventResult(this);
    }

    /// <summary>Field number for the "modelCode" field.</summary>
    public const int ModelCodeFieldNumber = 1;
    private int modelCode_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int ModelCode {
      get { return modelCode_; }
      set {
        modelCode_ = value;
      }
    }

    /// <summary>Field number for the "perilSetCode" field.</summary>
    public const int PerilSetCodeFieldNumber = 2;
    private int perilSetCode_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int PerilSetCode {
      get { return perilSetCode_; }
      set {
        perilSetCode_ = value;
      }
    }

    /// <summary>Field number for the "yearId" field.</summary>
    public const int YearIdFieldNumber = 3;
    private int yearId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int YearId {
      get { return yearId_; }
      set {
        yearId_ = value;
      }
    }

    /// <summary>Field number for the "eventId" field.</summary>
    public const int EventIdFieldNumber = 4;
    private int eventId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int EventId {
      get { return eventId_; }
      set {
        eventId_ = value;
      }
    }

    /// <summary>Field number for the "groundUp" field.</summary>
    public const int GroundUpFieldNumber = 5;
    private double groundUp_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public double GroundUp {
      get { return groundUp_; }
      set {
        groundUp_ = value;
      }
    }

    /// <summary>Field number for the "gross" field.</summary>
    public const int GrossFieldNumber = 6;
    private double gross_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public double Gross {
      get { return gross_; }
      set {
        gross_ = value;
      }
    }

    /// <summary>Field number for the "retained" field.</summary>
    public const int RetainedFieldNumber = 7;
    private double retained_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public double Retained {
      get { return retained_; }
      set {
        retained_ = value;
      }
    }

    /// <summary>Field number for the "preCatNet" field.</summary>
    public const int PreCatNetFieldNumber = 8;
    private double preCatNet_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public double PreCatNet {
      get { return preCatNet_; }
      set {
        preCatNet_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as EventResult);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(EventResult other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (ModelCode != other.ModelCode) return false;
      if (PerilSetCode != other.PerilSetCode) return false;
      if (YearId != other.YearId) return false;
      if (EventId != other.EventId) return false;
      if (!pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(GroundUp, other.GroundUp)) return false;
      if (!pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(Gross, other.Gross)) return false;
      if (!pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(Retained, other.Retained)) return false;
      if (!pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(PreCatNet, other.PreCatNet)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (ModelCode != 0) hash ^= ModelCode.GetHashCode();
      if (PerilSetCode != 0) hash ^= PerilSetCode.GetHashCode();
      if (YearId != 0) hash ^= YearId.GetHashCode();
      if (EventId != 0) hash ^= EventId.GetHashCode();
      if (GroundUp != 0D) hash ^= pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(GroundUp);
      if (Gross != 0D) hash ^= pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(Gross);
      if (Retained != 0D) hash ^= pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(Retained);
      if (PreCatNet != 0D) hash ^= pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(PreCatNet);
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (ModelCode != 0) {
        output.WriteRawTag(8);
        output.WriteInt32(ModelCode);
      }
      if (PerilSetCode != 0) {
        output.WriteRawTag(16);
        output.WriteInt32(PerilSetCode);
      }
      if (YearId != 0) {
        output.WriteRawTag(24);
        output.WriteInt32(YearId);
      }
      if (EventId != 0) {
        output.WriteRawTag(32);
        output.WriteInt32(EventId);
      }
      if (GroundUp != 0D) {
        output.WriteRawTag(41);
        output.WriteDouble(GroundUp);
      }
      if (Gross != 0D) {
        output.WriteRawTag(49);
        output.WriteDouble(Gross);
      }
      if (Retained != 0D) {
        output.WriteRawTag(57);
        output.WriteDouble(Retained);
      }
      if (PreCatNet != 0D) {
        output.WriteRawTag(65);
        output.WriteDouble(PreCatNet);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (ModelCode != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(ModelCode);
      }
      if (PerilSetCode != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(PerilSetCode);
      }
      if (YearId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(YearId);
      }
      if (EventId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(EventId);
      }
      if (GroundUp != 0D) {
        size += 1 + 8;
      }
      if (Gross != 0D) {
        size += 1 + 8;
      }
      if (Retained != 0D) {
        size += 1 + 8;
      }
      if (PreCatNet != 0D) {
        size += 1 + 8;
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(EventResult other) {
      if (other == null) {
        return;
      }
      if (other.ModelCode != 0) {
        ModelCode = other.ModelCode;
      }
      if (other.PerilSetCode != 0) {
        PerilSetCode = other.PerilSetCode;
      }
      if (other.YearId != 0) {
        YearId = other.YearId;
      }
      if (other.EventId != 0) {
        EventId = other.EventId;
      }
      if (other.GroundUp != 0D) {
        GroundUp = other.GroundUp;
      }
      if (other.Gross != 0D) {
        Gross = other.Gross;
      }
      if (other.Retained != 0D) {
        Retained = other.Retained;
      }
      if (other.PreCatNet != 0D) {
        PreCatNet = other.PreCatNet;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 8: {
            ModelCode = input.ReadInt32();
            break;
          }
          case 16: {
            PerilSetCode = input.ReadInt32();
            break;
          }
          case 24: {
            YearId = input.ReadInt32();
            break;
          }
          case 32: {
            EventId = input.ReadInt32();
            break;
          }
          case 41: {
            GroundUp = input.ReadDouble();
            break;
          }
          case 49: {
            Gross = input.ReadDouble();
            break;
          }
          case 57: {
            Retained = input.ReadDouble();
            break;
          }
          case 65: {
            PreCatNet = input.ReadDouble();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
