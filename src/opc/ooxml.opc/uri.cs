namespace ooxml.opc;

public interface IUri
{
    // Uri interface omitted
    IPartUri GetRelationshipsPartUri();

    IUri GetRelativeUri(IPartUri targetUri);

    IPartUri CombinePartUri(Uri relativeUri);
}

public interface IPartUri : IUri
{
    int ComparePartUri(IPartUri partUri);

    IUri GetSourceUri();

    bool IsRelationshipsPartUri();
}
