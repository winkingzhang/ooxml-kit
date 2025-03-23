namespace ooxml.opc;

public interface IOpcPackage
{
    IOpcPartSet PartSet { get; }

    IOpcRelationshipSet RelationshipSet { get; }
}

public interface IOpcPartSet : IEnumerable<IOpcPart>
{
    IOpcPart GetPart(IOpcPartUri name);

    IOpcPart CreatePart(IOpcPartUri name, ReadOnlySpan<char> contentType, CompressionOptions compressionOption);

    void DeletePart(IOpcPartUri name);

    bool PartExists(IOpcPartUri name);
}

public interface IOpcPart
{
    IOpcRelationshipSet RelationshipSet { get; }

    IOpcPartUri Name { get; }

    ReadOnlySpan<char> ContentType { get; }

    CompressionOptions CompressionOption { get; }

    Stream GetContentStream();
}

public interface IOpcRelationshipSet : IEnumerable<IOpcRelationship>
{
    IOpcRelationship GetRelationship(ReadOnlySpan<char> relationshipIdentifier);

    IOpcRelationship CreateRelationship(ReadOnlySpan<char> relationshipIdentifier, 
        ReadOnlySpan<char> relationshipType,
        Uri? targetUri, 
        UriTargetMode targetMode);
    
    void DeleteRelationship(ReadOnlySpan<char> relationshipIdentifier);
    
    bool RelationshipExists(ReadOnlySpan<char> relationshipIdentifier);

    IEnumerator<IOpcRelationship> GetEnumeratorForType(ReadOnlySpan<char> relationshipType);

    Stream GetRelationshipsContentStream();
}

public interface IOpcRelationship
{
    ReadOnlySpan<char> Id { get; }
    ReadOnlySpan<char> RelationshipType { get; }
    
    IOpcUri SourceUri { get; }
    Uri TargetUri { get; }
    UriTargetMode TargetMode { get; }
}
