namespace ooxml.opc;

public enum OpcReadFlags
{
    ReadDefault = 0,
    ValidateOnLoad = 0x1,
    CacheOnAccess = 0x2,
}

public enum OpcWriteFlags
{
    WriteDefault = 0,
    WriteForceZip32 = 0x1
}

public enum CompressionOptions
{
    None = -1,
    Normal = 0,
    Maximum = 1,
    Fast = 2,
    SuperFast = 3,
}

public enum UriTargetMode
{
    Internal = 0,
    External = 1,
}

public enum SignatureTimeFormat
{
    Milliseconds = 0,
    Seconds = 1,
    Minutes = 2,
    Days = 3,
    Months = 4,
    Years = 5
}
