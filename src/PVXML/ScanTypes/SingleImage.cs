using System;
using System.Xml.Linq;
using System.Xml.XPath;

namespace PVXML.ScanTypes;

public class SingleImage : IScan
{
    public PVState PVState { get; private set; }
    public ScanType ScanType => ScanType.SingleImage;

    public SingleImage(string path)
    {
        PVState = new PVState(path);
        XDocument xmlDoc = PVState.XmlDoc;
        AssertValidScan(xmlDoc);
    }

    public string GetSummary() => PVState.GetSummary();

    private static void AssertValidScan(XDocument xmlDoc)
    {
        var sequenceElements = xmlDoc.XPathSelectElements("/PVScan/Sequence");
        if (sequenceElements.Count() != 1)
            throw new InvalidOperationException("expected single Sequence element");

        var sequenceElement = sequenceElements.First();
        if (sequenceElement.Attribute("type").Value != "Single")
            throw new InvalidOperationException("Expected series of type Single");
    }
}