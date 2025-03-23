namespace ooxml.opc;

public static class OpcFactory
{
    public static IPartUri CreatePartUri(ReadOnlySpan<char> uri) =>
        throw new NotImplementedException();

    public static IPackage CreatePackage() =>
        throw new NotImplementedException();

    public static ValueTask<IPackage> ReadToPackageAsync(this Stream stream, ReadFlags flags) =>
        throw new NotImplementedException();

    public static ValueTask WritePackageToStreamAsync(this IPackage package, Stream stream, WriteFlags flags) =>
        throw new NotImplementedException();

    public static IDigitalSignatureManager CreateDigitalSignatureManager(this IPackage package) =>
        throw new NotImplementedException();
}

public interface IPackage
{
    IPartSet PartSet { get; }

    IRelationshipSet RelationshipSet { get; }
}
