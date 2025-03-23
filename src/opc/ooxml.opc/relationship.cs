namespace ooxml.opc;

public interface IRelationship
{
    ReadOnlySpan<char> Id { get; }
    ReadOnlySpan<char> RelationshipType { get; }
    
    IUri SourceUri { get; }
    IUri TargetUri { get; }
    UriTargetMode TargetMode { get; }
}

public interface IRelationshipSet : IEnumerable<IRelationship>
{
    IRelationship GetRelationship(ReadOnlySpan<char> relationshipIdentifier);

    IRelationship CreateRelationship(ReadOnlySpan<char> relationshipIdentifier, 
        ReadOnlySpan<char> relationshipType,
        Uri? targetUri, 
        UriTargetMode targetMode);
    
    void DeleteRelationship(ReadOnlySpan<char> relationshipIdentifier);
    
    bool RelationshipExists(ReadOnlySpan<char> relationshipIdentifier);

    IEnumerator<IRelationship> GetEnumeratorForType(ReadOnlySpan<char> relationshipType);

    Stream GetRelationshipsContentStream();
}
