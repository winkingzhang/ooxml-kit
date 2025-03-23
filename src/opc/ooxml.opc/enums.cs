namespace ooxml.opc;

public enum ReadFlags
{
    ReadDefault = 0,
    ValidateOnLoad = 0x1,
    CacheOnAccess = 0x2,
}

public enum WriteFlags
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

public enum CanonicalizationMethod
{
    None = 0,
    C14N = 1,
    C14NWithComments = 2,
}

public enum RelationshipSigningOption
{
    UsingSelectors = 0,
    Part = 1,
}

public enum RelationshipSelector
{
    SelectById = 0,
    SelectByType = 1,
}
