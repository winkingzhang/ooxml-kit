namespace ooxml.opc;

public interface IOpcSignatureCustomObjectSet : IEnumerable<IOpcSignatureCustomObject>
{
    IOpcSignatureCustomObject Create(ReadOnlySpan<char> xmlMarkup);
    void Delete(IOpcSignatureCustomObject customObject);
}
