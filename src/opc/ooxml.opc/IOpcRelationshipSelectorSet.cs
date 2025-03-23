namespace ooxml.opc;

public interface IOpcRelationshipSelectorSet : IEnumerable<IOpcRelationshipSelector>
{
    IOpcRelationshipSelector Create(RelationshipSelector selector, ReadOnlySpan<char> selectionCriterion);
    void Delete(IOpcRelationshipSelector relationshipSelector);
}
