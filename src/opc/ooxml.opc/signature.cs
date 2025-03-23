namespace ooxml.opc;

public interface IDigitalSignatureManager : IEnumerable<IDigitalSignature>
{
    IPartUri SignatureOriginPartName { get; set; }

    void RemoveSignature(IPartUri signaturePartName);

    ISigningOptions CreateSigningOptions();

    bool Validate(IDigitalSignature signature, CertContext certificate);

    IDigitalSignature Sign(CertContext certificate, ISigningOptions options);

    IDigitalSignature ReplaceSignatureXml(IPartUri signaturePartName, ReadOnlySpan<char> newSignatureXml);
}

public interface CertContext
{
    uint CertEncodingType { get; }
    ReadOnlySpan<byte> CertEncoded { get; }
}

public interface IDigitalSignature
{
    (string Prefix, string Namespace)[] Namespaces { get; }
    ReadOnlySpan<char> SignatureId { get; }
    IPartUri SignaturePartName { get; }
    ReadOnlySpan<char> SignatureMethod { get; }
    CanonicalizationMethod CanonicalizationMethod { get; }
    ReadOnlySpan<byte> SignatureValue { get; }
    IEnumerator<ISignaturePartReference> GetSignaturePartReferenceEnumerator();
    IEnumerator<ISignatureRelationshipReference> GetSignatureRelationshipReferenceEnumerator();
    ReadOnlySpan<char> SigningTime { get; }
    SignatureTimeFormat TimeFormat { get; }
    ISignatureReference PackageObjectReference { get; }
    IEnumerator<CertContext> GetCertificateEnumerator();
    IEnumerator<ISignatureReference> GetCustomReferenceEnumerator();
    IEnumerator<ISignatureCustomObject> GetCustomObjectEnumerator();
    ReadOnlySpan<char> GetSignatureXml();
}

public interface ISignatureCustomObject
{
    ReadOnlySpan<char> GetXml();
}

public interface ISignatureCustomObjectSet : IEnumerable<ISignatureCustomObject>
{
    ISignatureCustomObject Create(ReadOnlySpan<char> xmlMarkup);
    void Delete(ISignatureCustomObject customObject);
}

public interface ISignatureReferenceSet : IEnumerable<ISignatureReference>
{
    ISignatureReference Create(Uri referenceUri,
        ReadOnlySpan<char> referenceId,
        ReadOnlySpan<char> type,
        ReadOnlySpan<char> digestMethod,
        CanonicalizationMethod transformMethod);

    void Delete(ISignatureReference reference);
}

public interface ISignatureReference
{
    ReadOnlySpan<char> Id { get; }
    Uri Uri { get; }
    ReadOnlySpan<char> Type { get; }
    ReadOnlySpan<char> DigestMethod { get; }
    ReadOnlySpan<byte> DigestValue { get; }
    CanonicalizationMethod TransformMethod { get; }
}

public interface ISignaturePartReference
{
    IPartUri PartName { get; }
    ReadOnlySpan<char> ContentType { get; }
    ReadOnlySpan<char> DigestMethod { get; }
    ReadOnlySpan<byte> DigestValue { get; }
    CanonicalizationMethod TransformMethod { get; }
}

public interface ISignaturePartReferenceSet : IEnumerable<ISignaturePartReference>
{
    ISignaturePartReference Create(IPartUri partUri, ReadOnlySpan<char> digestMethod,
        CanonicalizationMethod transformMethod);

    void Delete(ISignaturePartReference partReference);
}


public interface ISigningOptions
{
    //TODO: Add properties
}

public interface ISignatureRelationshipReferenceSet
    : IEnumerable<ISignatureRelationshipReference>
{
    ISignatureRelationshipReference Create(IUri sourceUri,
        ReadOnlySpan<char> digestMethod,
        RelationshipSigningOption relationshipSigningOption,
        IRelationshipSelectorSet selectorSet,
        CanonicalizationMethod transformMethod);

    IRelationshipSelectorSet CreateRelationshipSelectorSet();

    void Delete(ISignatureRelationshipReference relationshipReference);
}

public interface ISignatureRelationshipReference : IEnumerable<IRelationshipSelector>
{
    IUri SourceUri { get; }
    ReadOnlySpan<char> DigestMethod { get; }
    ReadOnlySpan<byte> DigestValue { get; }
    CanonicalizationMethod TransformMethod { get; }
    RelationshipSigningOption RelationshipSigningOption { get; }
}

public interface IRelationshipSelector
{
    RelationshipSelector SelectorType { get; }
    ReadOnlySpan<char> SelectionCriterion { get; }
}

public interface IRelationshipSelectorSet : IEnumerable<IRelationshipSelector>
{
    IRelationshipSelector Create(RelationshipSelector selector, ReadOnlySpan<char> selectionCriterion);
    void Delete(IRelationshipSelector relationshipSelector);
}
