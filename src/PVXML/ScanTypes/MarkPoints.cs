using System;
using System.Text;
using System.Xml.Linq;

namespace PVXML.ScanTypes;

public class MarkPoints
{
    public readonly DateTime DateTime;

    public MarkPoints(string folder)
    {
        string[] xmlFiles = Directory.GetFiles(folder, "MarkPoints-*.xml");
        string[] patternXmlFiles = xmlFiles.Where(x => Path.GetFileName(x).EndsWith("_MarkPoints.xml")).ToArray();
        string[] stateXmlFiles = xmlFiles.Where(x => !Path.GetFileName(x).EndsWith("_MarkPoints.xml")).ToArray();

        var xmlDoc = XDocument.Parse(File.ReadAllText(stateXmlFiles.First()));
        string scanDate = xmlDoc.Element("PVScan")?.Attribute("date")?.Value
            ?? throw new InvalidOperationException("date not found in XML file");
        DateTime = DateTime.Parse(scanDate);
    }

    public static string GetPointsSummary(string xmlText)
    {
        string[] parts = xmlText.Split(" ")
            .Where(x => x.Contains("="))
            .Select(x => x.Trim())
            .Where(x => !string.IsNullOrWhiteSpace(x))
            .ToArray();

        string[] keysOfInterest =
        {
            "IterationDelay", "Repetitions", "UncagingLaserPower", "TriggerCount", "AsyncSyncFrequency",
            "InitialDelay", "InterPointDelay", "SpiralRevolutions", "IsSpiral", "SpiralSizeInMicrons"
        };

        StringBuilder sb = new();
        foreach (string part in parts)
        {
            string key = part.Split("=")[0];
            string value = part.Split("\"")[1];
            if (keysOfInterest.Contains(key))
                sb.AppendLine($"{key}: {value}");
        }
        return sb.ToString();
    }
}
