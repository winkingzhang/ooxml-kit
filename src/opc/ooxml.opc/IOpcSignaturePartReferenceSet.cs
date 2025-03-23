namespace ooxml.opc;

public interface IOpcSignaturePartReferenceSet : IEnumerable<IOpcSignaturePartReference>
{
    IOpcSignaturePartReference Create(IOpcPartUri partUri, ReadOnlySpan<char> digestMethod,
        CanonicalizationMethod transformMethod);

    void Delete(IOpcSignaturePartReference partReference);
}
