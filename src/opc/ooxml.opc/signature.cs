namespace ooxml.opc;

public interface IOpcDigitalSignatureManager : IEnumerable<IOpcDigitalSignature>
{
    IOpcPartUri SignatureOriginPartName { get; set; }

    void RemoveSignature(IOpcPartUri signaturePartName);

    IOpcSigningOptions CreateSigningOptions();

    bool Validate(IOpcDigitalSignature signature, CertContext certificate);

    IOpcDigitalSignature Sign(CertContext certificate, IOpcSigningOptions options);

    IOpcDigitalSignature ReplaceSignatureXml(IOpcPartUri signaturePartName, ReadOnlySpan<char> newSignatureXml);
}

public interface CertContext
{
    uint CertEncodingType { get; }
    ReadOnlySpan<byte> CertEncoded { get; }
}

public interface IOpcDigitalSignature
{
    (string Prefix, string Namespace)[] Namespaces { get; }
    ReadOnlySpan<char> SignatureId { get; }
    IOpcPartUri SignaturePartName { get; }
    ReadOnlySpan<char> SignatureMethod { get; }
    CanonicalizationMethod CanonicalizationMethod { get; }
    ReadOnlySpan<byte> SignatureValue { get; }
    IEnumerator<IOpcSignaturePartReference> GetSignaturePartReferenceEnumerator();
    IEnumerator<IOpcSignatureRelationshipReference> GetSignatureRelationshipReferenceEnumerator();
    ReadOnlySpan<char> SigningTime { get; }
    SignatureTimeFormat TimeFormat { get; }
    IOpcSignatureReference PackageObjectReference { get; }
    IEnumerator<CertContext> GetCertificateEnumerator();
    IEnumerator<IOpcSignatureReference> GetCustomReferenceEnumerator();
    IEnumerator<IOpcSignatureCustomObject> GetCustomObjectEnumerator();
    ReadOnlySpan<char> GetSignatureXml();
}

public interface IOpcSignatureReferenceSet : IEnumerable<IOpcSignatureReference>
{
    IOpcSignatureReference Create(Uri referenceUri,
        ReadOnlySpan<char> referenceId,
        ReadOnlySpan<char> type,
        ReadOnlySpan<char> digestMethod,
        CanonicalizationMethod transformMethod);

    void Delete(IOpcSignatureReference reference);
}

public interface IOpcSignatureReference
{
    ReadOnlySpan<char> Id { get; }
    Uri Uri { get; }
    ReadOnlySpan<char> Type { get; }
    ReadOnlySpan<char> DigestMethod { get; }
    ReadOnlySpan<byte> DigestValue { get; }
    CanonicalizationMethod TransformMethod { get; }
}

public interface IOpcSigningOptions
{
    //TODO: Add properties
}

