namespace ooxml.opc;

public interface IOpcUri
{
    // Uri interface omitted
    IOpcPartUri GetRelationshipsPartUri();

    Uri GetRelativeUri(IOpcPartUri targetUri);

    IOpcPartUri CombinePartUri(Uri relativeUri);
}

public interface IOpcPartUri : IOpcUri
{
    int ComparePartUri(IOpcPartUri partUri);

    IOpcUri GetSourceUri();

    bool IsRelationshipsPartUri();
}
