namespace ooxml.SimpleTypes;

public abstract class Restriction
{
    public abstract ReadOnlySpan<char> ToXmlFragment();

    public class String : Restriction
    {
        public override ReadOnlySpan<char> ToXmlFragment() => """<restriction base="xsd:string"/>""".AsSpan();
    }
}

public record SimpleType<TElement>(TElement Value, string ElementName, Restriction Restriction)
{
    public TElement Value { get; set; } = Value;

    public ReadOnlySpan<char> ToXmlFragment() =>
        $"""<simpleType name="{ElementName}">{Restriction.ToXmlFragment()}</simpleType>""".AsSpan();
}

// represents the following XML schema definition:
// <simpleType name="ST_Fraction">
//   <restriction base="xsd:string"/>
// </simpleType>
public record Fraction(string Value) : SimpleType<string>(Value, "ST_Fraction", new Restriction.String());
