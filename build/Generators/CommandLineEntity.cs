using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;
using System.Threading.Tasks;
using System.Xml;
using System.Security;
using Nuke.Unreal;
using Nuke.Common.Utilities;

namespace build.Generators;
public abstract class CommandLineEntity
{
    public string ConfigName { init; get; }
    public string CliName { init; get; }
    public List<UnrealCompatibility> Compatibility { get; set; } = new();
    
    public string CompatibilityRender => string.Join(
        " | ",
        Compatibility
            .Select(c => nameof(UnrealCompatibility) + "." + c.ToString())
    );

    public XDocument DocsXml { get; set; } = XDocument.Parse("<r />");
    public string Docs =>
        string.Join(
            Environment.NewLine,
            DocsXml.Element("r").Elements()
        )
        .DocsXmlComment();

    public XElement DocsRoot => DocsXml.Element("r");

    public void AddDocsTag(string tag, string text)
    {
        text = SecurityElement.Escape(text);
        var summaryElement = DocsRoot.Element(tag);
        if (summaryElement == null)
        {
            DocsRoot.Add(XElement.Parse($"<{tag}>{text}</{tag}>"));
        }
        else
        {
            summaryElement.Value += Environment.NewLine + text;
        }
    }
}

public static class CommandLineEntityExtensions
{
    public static T AddSummary<T>(this T self, string text) where T : CommandLineEntity
    {
        if (string.IsNullOrWhiteSpace(text)) return self;
        self.AddDocsTag("summary", text);
        return self;
    }

    public static T AddRemarks<T>(this T self, string text) where T : CommandLineEntity
    {
        if (string.IsNullOrWhiteSpace(text)) return self;
        self.AddDocsTag("remarks", text);
        return self;
    }
    
    public static T AddXElementContents<T>(this T self, XElement element) where T : CommandLineEntity
    {
        if (element == null) return self;
        foreach(var el in element.Elements())
        {
            self.DocsRoot.Add(el);
        }
        return self;
    }

    public static T AddRootlessXmlDocs<T>(this T self, string xml) where T : CommandLineEntity
    {
        if (string.IsNullOrWhiteSpace(xml)) return self;
        return self.AddXElementContents(XElement.Parse($"<r>{xml}</r>"));
    }

    public static T MergeDocs<T>(this T self, CommandLineEntity other) where T : CommandLineEntity
    {
        foreach(var el in other.DocsRoot.Elements())
        {
            var otherEl = self.DocsRoot.Element(el.Name);
            if (otherEl == null)
            {
                self.DocsRoot.Add(el.Clone());
            }
            else
            {
                if (!otherEl.Value.Contains(el.Value))
                    otherEl.Value += Environment.NewLine + el.Value;
            }
        }
        return self;
    }
}