namespace ooxml.opc;

public interface IPart
{
    IRelationshipSet RelationshipSet { get; }

    IPartUri Name { get; }

    ReadOnlySpan<char> ContentType { get; }

    CompressionOptions CompressionOption { get; }

    Stream GetContentStream();
}

public interface IPartSet : IEnumerable<IPart>
{
    IPart GetPart(IPartUri name);

    IPart CreatePart(IPartUri name, ReadOnlySpan<char> contentType, CompressionOptions compressionOption);

    void DeletePart(IPartUri name);

    bool PartExists(IPartUri name);
}
