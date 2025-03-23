namespace ooxml.opc;

public interface IOpcSignatureRelationshipReference : IEnumerable<IOpcRelationshipSelector>
{
    IOpcUri SourceUri { get; }
    ReadOnlySpan<char> DigestMethod { get; }
    ReadOnlySpan<byte> DigestValue { get; }
    CanonicalizationMethod TransformMethod { get; }
    RelationshipSigningOption RelationshipSigningOption { get; }
}

public interface IOpcRelationshipSelector
{
    RelationshipSelector SelectorType { get; }
    ReadOnlySpan<char> SelectionCriterion { get; }
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
