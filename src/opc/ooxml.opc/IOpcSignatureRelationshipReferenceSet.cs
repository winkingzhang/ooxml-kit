namespace ooxml.opc;

public interface IOpcSignatureRelationshipReferenceSet
    : IEnumerable<IOpcSignatureRelationshipReference>
{
    IOpcSignatureRelationshipReference Create(IOpcUri sourceUri,
        ReadOnlySpan<char> digestMethod,
        RelationshipSigningOption relationshipSigningOption,
        IOpcRelationshipSelectorSet selectorSet,
        CanonicalizationMethod transformMethod);

    IOpcRelationshipSelectorSet CreateRelationshipSelectorSet();

    void Delete(IOpcSignatureRelationshipReference relationshipReference);
}
