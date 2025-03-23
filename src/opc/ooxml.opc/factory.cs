namespace ooxml.opc;

public static class OpcFactory
{
    public static IOpcPartUri CreatePartUri(ReadOnlySpan<char> uri) =>
        throw new NotImplementedException();

    public static IOpcPackage CreatePackage() =>
        throw new NotImplementedException();

    public static ValueTask<IOpcPackage> ReadToOpcPackageAsync(this Stream stream, OpcReadFlags flags) =>
        throw new NotImplementedException();

    public static ValueTask WritePackageToStreamAsync(this IOpcPackage package, Stream stream, OpcWriteFlags flags) =>
        throw new NotImplementedException();

    public static IOpcDigitalSignatureManager CreateDigitalSignatureManager(this IOpcPackage package) =>
        throw new NotImplementedException();
}
