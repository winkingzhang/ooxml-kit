namespace ooxml;

public class FileType
{
    public FileType(string defaultDirectory, string defaultFileName, string overrideType, string relationType,
        string enumerateType = "", bool enumerated = false, bool enumeratedGlobal = false)
    {
        
    }
    
    public string DefaultDirectory { get; set; }
    public string DefaultFileName { get; set; }
    public string OverrideType { get; set; }
    public string RelationType { get; set; }
    public string EnumerateType { get; set; }
    public bool Enumerated { get; set; }
    public bool EnumeratedGlobal { get; set; }
    
    public static readonly FileType Document = new("word", "document", "docx", "http://schemas.openxmlformats.org/officeDocument/2006/relationships/officeDocument");
    public static readonly FileType MacroEnabledDocument = new("word", "document", "docm", "http://schemas.openxmlformats.org/officeDocument/2006/relationships/officeDocument");
    public static readonly FileType Template = new("word", "document", "dotx", "http://schemas.openxmlformats.org/officeDocument/2006/relationships/officeDocument");
    public static readonly FileType MacroEnabledTemplate = new("word", "document", "dotm", "http://schemas.openxmlformats.org/officeDocument/2006/relationships/officeDocument");
    public static readonly FileType AddIn = new("word", "document", "dotx", "http://schemas.openxmlformats.org/officeDocument/2006/relationships/officeDocument");
    public static readonly FileType MacroEnabledAddIn = new("word", "document", "dotm", "http://schemas.openxmlformats.org/officeDocument/2006/relationships/officeDocument");
    public static readonly FileType DocumentWithMacro = new("word", "document", "docm", "http://schemas.openxmlformats.org/officeDocument/2006/relationships/officeDocument");
    public static readonly FileType TemplateWithMacro = new("word", "document", "dotm", "http://schemas.openxmlformats.org/officeDocument/2006/relationships/officeDocument");
    public static readonly FileType TemplateWithMacroEnabled = new("word", "document", "dotm", "http://schemas.openxmlformats.org/officeDocument/2006/relationships/officeDocument");
}
