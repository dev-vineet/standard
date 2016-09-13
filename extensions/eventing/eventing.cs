/*
APIs removed/broken by this factoring:

*/
namespace System.Diagnostics.Eventing
{
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Explicit, Size=16)]
    public partial struct EventDescriptor
    {
        public EventDescriptor(int id, byte version, byte channel, byte level, byte opcode, int task, long keywords) { throw null;}
        public byte Channel { get { throw null; } }
        public int EventId { get { throw null; } }
        public long Keywords { get { throw null; } }
        public byte Level { get { throw null; } }
        public byte Opcode { get { throw null; } }
        public int Task { get { throw null; } }
        public byte Version { get { throw null; } }
    }
    public partial class EventProvider : System.IDisposable
    {
        public EventProvider(System.Guid providerGuid) { }
        public virtual void Close() { }
        public static System.Guid CreateActivityId() { throw null; }
        public void Dispose() { }
        protected virtual void Dispose(bool disposing) { }
        ~EventProvider() { }
        public static System.Diagnostics.Eventing.EventProvider.WriteEventErrorCode GetLastWriteEventError() { throw null; }
        public bool IsEnabled() { throw null; }
        public bool IsEnabled(byte level, long keywords) { throw null; }
        public static void SetActivityId(ref System.Guid id) { }
        protected bool WriteEvent(ref System.Diagnostics.Eventing.EventDescriptor eventDescriptor, int dataCount, System.IntPtr data) { throw null; }
        public bool WriteEvent(ref System.Diagnostics.Eventing.EventDescriptor eventDescriptor, params object[] eventPayload) { throw null; }
        public bool WriteEvent(ref System.Diagnostics.Eventing.EventDescriptor eventDescriptor, string data) { throw null; }
        public bool WriteMessageEvent(string eventMessage) { throw null; }
        public bool WriteMessageEvent(string eventMessage, byte eventLevel, long eventKeywords) { throw null; }
        protected bool WriteTransferEvent(ref System.Diagnostics.Eventing.EventDescriptor eventDescriptor, System.Guid relatedActivityId, int dataCount, System.IntPtr data) { throw null; }
        public bool WriteTransferEvent(ref System.Diagnostics.Eventing.EventDescriptor eventDescriptor, System.Guid relatedActivityId, params object[] eventPayload) { throw null; }
        public enum WriteEventErrorCode
        {
            EventTooBig = 2,
            NoError = 0,
            NoFreeBuffers = 1,
        }
    }
    public partial class EventProviderTraceListener : System.Diagnostics.TraceListener
    {
        public EventProviderTraceListener(string providerId) { }
        public EventProviderTraceListener(string providerId, string name) { }
        public EventProviderTraceListener(string providerId, string name, string delimiter) { }
        public string Delimiter { get { throw null; } set { } }
        public sealed override bool IsThreadSafe { get { throw null; } }
        public override void Close() { }
        public override void Fail(string message, string detailMessage) { }
        public sealed override void Flush() { }
        public sealed override void TraceData(System.Diagnostics.TraceEventCache eventCache, string source, System.Diagnostics.TraceEventType eventType, int id, object data) { }
        public sealed override void TraceData(System.Diagnostics.TraceEventCache eventCache, string source, System.Diagnostics.TraceEventType eventType, int id, params object[] data) { }
        public sealed override void TraceEvent(System.Diagnostics.TraceEventCache eventCache, string source, System.Diagnostics.TraceEventType eventType, int id) { }
        public sealed override void TraceEvent(System.Diagnostics.TraceEventCache eventCache, string source, System.Diagnostics.TraceEventType eventType, int id, string message) { }
        public sealed override void TraceEvent(System.Diagnostics.TraceEventCache eventCache, string source, System.Diagnostics.TraceEventType eventType, int id, string format, params object[] args) { }
        public sealed override void TraceTransfer(System.Diagnostics.TraceEventCache eventCache, string source, int id, string message, System.Guid relatedActivityId) { }
        public sealed override void Write(string message) { }
        public sealed override void WriteLine(string message) { }
    }
}
namespace System.Diagnostics.Eventing.Reader
{
    public partial class EventBookmark : System.Runtime.Serialization.ISerializable
    {
        protected EventBookmark(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
        protected virtual void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
        void System.Runtime.Serialization.ISerializable.GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
    }
    public sealed partial class EventKeyword
    {
        internal EventKeyword() { }
        public string DisplayName { get { throw null; } }
        public string Name { get { throw null; } }
        public long Value { get { throw null; } }
    }
    public sealed partial class EventLevel
    {
        internal EventLevel() { }
        public string DisplayName { get { throw null; } }
        public string Name { get { throw null; } }
        public int Value { get { throw null; } }
    }
    public partial class EventLogConfiguration : System.IDisposable
    {
        public EventLogConfiguration(string logName) { }
        public EventLogConfiguration(string logName, System.Diagnostics.Eventing.Reader.EventLogSession session) { }
        public bool IsClassicLog { get { throw null; } }
        public bool IsEnabled { get { throw null; } set { } }
        public string LogFilePath { get { throw null; } set { } }
        public System.Diagnostics.Eventing.Reader.EventLogIsolation LogIsolation { get { throw null; } }
        public System.Diagnostics.Eventing.Reader.EventLogMode LogMode { get { throw null; } set { } }
        public string LogName { get { throw null; } }
        public System.Diagnostics.Eventing.Reader.EventLogType LogType { get { throw null; } }
        public long MaximumSizeInBytes { get { throw null; } set { } }
        public string OwningProviderName { get { throw null; } }
        public System.Nullable<int> ProviderBufferSize { get { throw null; } }
        public System.Nullable<System.Guid> ProviderControlGuid { get { throw null; } }
        public System.Nullable<long> ProviderKeywords { get { throw null; } set { } }
        public System.Nullable<int> ProviderLatency { get { throw null; } }
        public System.Nullable<int> ProviderLevel { get { throw null; } set { } }
        public System.Nullable<int> ProviderMaximumNumberOfBuffers { get { throw null; } }
        public System.Nullable<int> ProviderMinimumNumberOfBuffers { get { throw null; } }
        public System.Collections.Generic.IEnumerable<string> ProviderNames { get { throw null; } }
        public string SecurityDescriptor { get { throw null; } set { } }
        public void Dispose() { }
        protected virtual void Dispose(bool disposing) { }
        public void SaveChanges() { }
    }
    public partial class EventLogException : System.Exception, System.Runtime.Serialization.ISerializable
    {
        public EventLogException() { }
        protected EventLogException(int errorCode) { }
        protected EventLogException(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext) { }
        public EventLogException(string message) { }
        public EventLogException(string message, System.Exception innerException) { }
        public override string Message { get { throw null; } }
        public override void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
    }
    public sealed partial class EventLogInformation
    {
        internal EventLogInformation() { }
        public System.Nullable<int> Attributes { get { throw null; } }
        public System.Nullable<System.DateTime> CreationTime { get { throw null; } }
        public System.Nullable<long> FileSize { get { throw null; } }
        public System.Nullable<bool> IsLogFull { get { throw null; } }
        public System.Nullable<System.DateTime> LastAccessTime { get { throw null; } }
        public System.Nullable<System.DateTime> LastWriteTime { get { throw null; } }
        public System.Nullable<long> OldestRecordNumber { get { throw null; } }
        public System.Nullable<long> RecordCount { get { throw null; } }
    }
    public partial class EventLogInvalidDataException : System.Diagnostics.Eventing.Reader.EventLogException
    {
        public EventLogInvalidDataException() { }
        protected EventLogInvalidDataException(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext) { }
        public EventLogInvalidDataException(string message) { }
        public EventLogInvalidDataException(string message, System.Exception innerException) { }
    }
    public enum EventLogIsolation
    {
        Application = 0,
        Custom = 2,
        System = 1,
    }
    public sealed partial class EventLogLink
    {
        internal EventLogLink() { }
        public string DisplayName { get { throw null; } }
        public bool IsImported { get { throw null; } }
        public string LogName { get { throw null; } }
    }
    public enum EventLogMode
    {
        AutoBackup = 1,
        Circular = 0,
        Retain = 2,
    }
    public partial class EventLogNotFoundException : System.Diagnostics.Eventing.Reader.EventLogException
    {
        public EventLogNotFoundException() { }
        protected EventLogNotFoundException(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext) { }
        public EventLogNotFoundException(string message) { }
        public EventLogNotFoundException(string message, System.Exception innerException) { }
    }
    public partial class EventLogPropertySelector : System.IDisposable
    {
        public EventLogPropertySelector(System.Collections.Generic.IEnumerable<string> propertyQueries) { }
        public void Dispose() { }
        protected virtual void Dispose(bool disposing) { }
    }
    public partial class EventLogProviderDisabledException : System.Diagnostics.Eventing.Reader.EventLogException
    {
        public EventLogProviderDisabledException() { }
        protected EventLogProviderDisabledException(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext) { }
        public EventLogProviderDisabledException(string message) { }
        public EventLogProviderDisabledException(string message, System.Exception innerException) { }
    }
    public partial class EventLogQuery
    {
        public EventLogQuery(string path, System.Diagnostics.Eventing.Reader.PathType pathType) { }
        public EventLogQuery(string path, System.Diagnostics.Eventing.Reader.PathType pathType, string query) { }
        public bool ReverseDirection { get { throw null; } set { } }
        public System.Diagnostics.Eventing.Reader.EventLogSession Session { get { throw null; } set { } }
        public bool TolerateQueryErrors { get { throw null; } set { } }
    }
    public partial class EventLogReader : System.IDisposable
    {
        public EventLogReader(System.Diagnostics.Eventing.Reader.EventLogQuery eventQuery) { }
        public EventLogReader(System.Diagnostics.Eventing.Reader.EventLogQuery eventQuery, System.Diagnostics.Eventing.Reader.EventBookmark bookmark) { }
        public EventLogReader(string path) { }
        public EventLogReader(string path, System.Diagnostics.Eventing.Reader.PathType pathType) { }
        public int BatchSize { get { throw null; } set { } }
        public System.Collections.Generic.IList<System.Diagnostics.Eventing.Reader.EventLogStatus> LogStatus { get { throw null; } }
        public void CancelReading() { }
        public void Dispose() { }
        protected virtual void Dispose(bool disposing) { }
        public System.Diagnostics.Eventing.Reader.EventRecord ReadEvent() { throw null; }
        public System.Diagnostics.Eventing.Reader.EventRecord ReadEvent(System.TimeSpan timeout) { throw null; }
        public void Seek(System.Diagnostics.Eventing.Reader.EventBookmark bookmark) { }
        public void Seek(System.Diagnostics.Eventing.Reader.EventBookmark bookmark, long offset) { }
        public void Seek(System.IO.SeekOrigin origin, long offset) { }
    }
    public partial class EventLogReadingException : System.Diagnostics.Eventing.Reader.EventLogException
    {
        public EventLogReadingException() { }
        protected EventLogReadingException(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext) { }
        public EventLogReadingException(string message) { }
        public EventLogReadingException(string message, System.Exception innerException) { }
    }
    public partial class EventLogRecord : System.Diagnostics.Eventing.Reader.EventRecord
    {
        internal EventLogRecord() { }
        public override System.Nullable<System.Guid> ActivityId { get { throw null; } }
        public override System.Diagnostics.Eventing.Reader.EventBookmark Bookmark { get { throw null; } }
        public string ContainerLog { get { throw null; } }
        public override int Id { get { throw null; } }
        public override System.Nullable<long> Keywords { get { throw null; } }
        public override System.Collections.Generic.IEnumerable<string> KeywordsDisplayNames { get { throw null; } }
        public override System.Nullable<byte> Level { get { throw null; } }
        public override string LevelDisplayName { get { throw null; } }
        public override string LogName { get { throw null; } }
        public override string MachineName { get { throw null; } }
        public System.Collections.Generic.IEnumerable<int> MatchedQueryIds { get { throw null; } }
        public override System.Nullable<short> Opcode { get { throw null; } }
        public override string OpcodeDisplayName { get { throw null; } }
        public override System.Nullable<int> ProcessId { get { throw null; } }
        public override System.Collections.Generic.IList<System.Diagnostics.Eventing.Reader.EventProperty> Properties { get { throw null; } }
        public override System.Nullable<System.Guid> ProviderId { get { throw null; } }
        public override string ProviderName { get { throw null; } }
        public override System.Nullable<int> Qualifiers { get { throw null; } }
        public override System.Nullable<long> RecordId { get { throw null; } }
        public override System.Nullable<System.Guid> RelatedActivityId { get { throw null; } }
        public override System.Nullable<int> Task { get { throw null; } }
        public override string TaskDisplayName { get { throw null; } }
        public override System.Nullable<int> ThreadId { get { throw null; } }
        public override System.Nullable<System.DateTime> TimeCreated { get { throw null; } }
        public override System.Security.Principal.SecurityIdentifier UserId { get { throw null; } }
        public override System.Nullable<byte> Version { get { throw null; } }
        protected override void Dispose(bool disposing) { }
        public override string FormatDescription() { throw null; }
        public override string FormatDescription(System.Collections.Generic.IEnumerable<object> values) { throw null; }
        public System.Collections.Generic.IList<object> GetPropertyValues(System.Diagnostics.Eventing.Reader.EventLogPropertySelector propertySelector) { throw null; }
        public override string ToXml() { throw null; }
    }
    public partial class EventLogSession : System.IDisposable
    {
        public EventLogSession() { }
        public EventLogSession(string server) { }
        public EventLogSession(string server, string domain, string user, System.Security.SecureString password, System.Diagnostics.Eventing.Reader.SessionAuthentication logOnType) { }
        public static System.Diagnostics.Eventing.Reader.EventLogSession GlobalSession { get { throw null; } }
        public void CancelCurrentOperations() { }
        public void ClearLog(string logName) { }
        public void ClearLog(string logName, string backupPath) { }
        public void Dispose() { }
        protected virtual void Dispose(bool disposing) { }
        public void ExportLog(string path, System.Diagnostics.Eventing.Reader.PathType pathType, string query, string targetFilePath) { }
        public void ExportLog(string path, System.Diagnostics.Eventing.Reader.PathType pathType, string query, string targetFilePath, bool tolerateQueryErrors) { }
        public void ExportLogAndMessages(string path, System.Diagnostics.Eventing.Reader.PathType pathType, string query, string targetFilePath) { }
        public void ExportLogAndMessages(string path, System.Diagnostics.Eventing.Reader.PathType pathType, string query, string targetFilePath, bool tolerateQueryErrors, System.Globalization.CultureInfo targetCultureInfo) { }
        public System.Diagnostics.Eventing.Reader.EventLogInformation GetLogInformation(string logName, System.Diagnostics.Eventing.Reader.PathType pathType) { throw null; }
        public System.Collections.Generic.IEnumerable<string> GetLogNames() { throw null; }
        public System.Collections.Generic.IEnumerable<string> GetProviderNames() { throw null; }
    }
    public sealed partial class EventLogStatus
    {
        internal EventLogStatus() { }
        public string LogName { get { throw null; } }
        public int StatusCode { get { throw null; } }
    }
    public enum EventLogType
    {
        Administrative = 0,
        Analytical = 2,
        Debug = 3,
        Operational = 1,
    }
    public partial class EventLogWatcher : System.IDisposable
    {
        public EventLogWatcher(System.Diagnostics.Eventing.Reader.EventLogQuery eventQuery) { }
        public EventLogWatcher(System.Diagnostics.Eventing.Reader.EventLogQuery eventQuery, System.Diagnostics.Eventing.Reader.EventBookmark bookmark) { }
        public EventLogWatcher(System.Diagnostics.Eventing.Reader.EventLogQuery eventQuery, System.Diagnostics.Eventing.Reader.EventBookmark bookmark, bool readExistingEvents) { }
        public EventLogWatcher(string path) { }
        public bool Enabled { get { throw null; } set { } }
        public event System.EventHandler<System.Diagnostics.Eventing.Reader.EventRecordWrittenEventArgs> EventRecordWritten { add { } remove { } }
        public void Dispose() { }
        protected virtual void Dispose(bool disposing) { }
    }
    public sealed partial class EventMetadata
    {
        internal EventMetadata() { }
        public string Description { get { throw null; } }
        public long Id { get { throw null; } }
        public System.Collections.Generic.IEnumerable<System.Diagnostics.Eventing.Reader.EventKeyword> Keywords { get { throw null; } }
        public System.Diagnostics.Eventing.Reader.EventLevel Level { get { throw null; } }
        public System.Diagnostics.Eventing.Reader.EventLogLink LogLink { get { throw null; } }
        public System.Diagnostics.Eventing.Reader.EventOpcode Opcode { get { throw null; } }
        public System.Diagnostics.Eventing.Reader.EventTask Task { get { throw null; } }
        public string Template { get { throw null; } }
        public byte Version { get { throw null; } }
    }
    public sealed partial class EventOpcode
    {
        internal EventOpcode() { }
        public string DisplayName { get { throw null; } }
        public string Name { get { throw null; } }
        public int Value { get { throw null; } }
    }
    public sealed partial class EventProperty
    {
        internal EventProperty() { }
        public object Value { get { throw null; } }
    }
    public abstract partial class EventRecord : System.IDisposable
    {
        protected EventRecord() { }
        public abstract System.Nullable<System.Guid> ActivityId { get; }
        public abstract System.Diagnostics.Eventing.Reader.EventBookmark Bookmark { get; }
        public abstract int Id { get; }
        public abstract System.Nullable<long> Keywords { get; }
        public abstract System.Collections.Generic.IEnumerable<string> KeywordsDisplayNames { get; }
        public abstract System.Nullable<byte> Level { get; }
        public abstract string LevelDisplayName { get; }
        public abstract string LogName { get; }
        public abstract string MachineName { get; }
        public abstract System.Nullable<short> Opcode { get; }
        public abstract string OpcodeDisplayName { get; }
        public abstract System.Nullable<int> ProcessId { get; }
        public abstract System.Collections.Generic.IList<System.Diagnostics.Eventing.Reader.EventProperty> Properties { get; }
        public abstract System.Nullable<System.Guid> ProviderId { get; }
        public abstract string ProviderName { get; }
        public abstract System.Nullable<int> Qualifiers { get; }
        public abstract System.Nullable<long> RecordId { get; }
        public abstract System.Nullable<System.Guid> RelatedActivityId { get; }
        public abstract System.Nullable<int> Task { get; }
        public abstract string TaskDisplayName { get; }
        public abstract System.Nullable<int> ThreadId { get; }
        public abstract System.Nullable<System.DateTime> TimeCreated { get; }
        public abstract System.Security.Principal.SecurityIdentifier UserId { get; }
        public abstract System.Nullable<byte> Version { get; }
        public void Dispose() { }
        protected virtual void Dispose(bool disposing) { }
        public abstract string FormatDescription();
        public abstract string FormatDescription(System.Collections.Generic.IEnumerable<object> values);
        public abstract string ToXml();
    }
    public sealed partial class EventRecordWrittenEventArgs : System.EventArgs
    {
        internal EventRecordWrittenEventArgs() { }
        public System.Exception EventException { get { throw null; } }
        public System.Diagnostics.Eventing.Reader.EventRecord EventRecord { get { throw null; } }
    }
    public sealed partial class EventTask
    {
        internal EventTask() { }
        public string DisplayName { get { throw null; } }
        public System.Guid EventGuid { get { throw null; } }
        public string Name { get { throw null; } }
        public int Value { get { throw null; } }
    }
    public enum PathType
    {
        FilePath = 2,
        LogName = 1,
    }
    public partial class ProviderMetadata : System.IDisposable
    {
        public ProviderMetadata(string providerName) { }
        public ProviderMetadata(string providerName, System.Diagnostics.Eventing.Reader.EventLogSession session, System.Globalization.CultureInfo targetCultureInfo) { }
        public string DisplayName { get { throw null; } }
        public System.Collections.Generic.IEnumerable<System.Diagnostics.Eventing.Reader.EventMetadata> Events { get { throw null; } }
        public System.Uri HelpLink { get { throw null; } }
        public System.Guid Id { get { throw null; } }
        public System.Collections.Generic.IList<System.Diagnostics.Eventing.Reader.EventKeyword> Keywords { get { throw null; } }
        public System.Collections.Generic.IList<System.Diagnostics.Eventing.Reader.EventLevel> Levels { get { throw null; } }
        public System.Collections.Generic.IList<System.Diagnostics.Eventing.Reader.EventLogLink> LogLinks { get { throw null; } }
        public string MessageFilePath { get { throw null; } }
        public string Name { get { throw null; } }
        public System.Collections.Generic.IList<System.Diagnostics.Eventing.Reader.EventOpcode> Opcodes { get { throw null; } }
        public string ParameterFilePath { get { throw null; } }
        public string ResourceFilePath { get { throw null; } }
        public System.Collections.Generic.IList<System.Diagnostics.Eventing.Reader.EventTask> Tasks { get { throw null; } }
        public void Dispose() { }
        protected virtual void Dispose(bool disposing) { }
    }
    public enum SessionAuthentication
    {
        Default = 0,
        Kerberos = 2,
        Negotiate = 1,
        Ntlm = 3,
    }
    [System.FlagsAttribute]
    public enum StandardEventKeywords : long
    {
        AuditFailure = (long)4503599627370496,
        AuditSuccess = (long)9007199254740992,
        [System.ObsoleteAttribute("Incorrect value: use CorrelationHint2 instead", false)]
        CorrelationHint = (long)4503599627370496,
        CorrelationHint2 = (long)18014398509481984,
        EventLogClassic = (long)36028797018963968,
        None = (long)0,
        ResponseTime = (long)281474976710656,
        Sqm = (long)2251799813685248,
        WdiContext = (long)562949953421312,
        WdiDiagnostic = (long)1125899906842624,
    }
    public enum StandardEventLevel
    {
        Critical = 1,
        Error = 2,
        Informational = 4,
        LogAlways = 0,
        Verbose = 5,
        Warning = 3,
    }
    public enum StandardEventOpcode
    {
        DataCollectionStart = 3,
        DataCollectionStop = 4,
        Extension = 5,
        Info = 0,
        Receive = 240,
        Reply = 6,
        Resume = 7,
        Send = 9,
        Start = 1,
        Stop = 2,
        Suspend = 8,
    }
    public enum StandardEventTask
    {
        None = 0,
    }
}