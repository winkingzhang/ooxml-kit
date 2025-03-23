namespace ooxml.opc;

public interface IOpcSignaturePartReference
{
    IOpcPartUri PartName { get; }
    ReadOnlySpan<char> ContentType { get; }
    ReadOnlySpan<char> DigestMethod { get; }
    ReadOnlySpan<byte> DigestValue { get; }
    CanonicalizationMethod TransformMethod { get; }
}

public enum CanonicalizationMethod
{
    None = 0,
    C14N = 1,
    C14NWithComments = 2,
}
