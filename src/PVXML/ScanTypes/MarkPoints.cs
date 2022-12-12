using System;
using System.Collections.Generic;
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

    public static string GetPointsSummary(string xmlText, string envText)
    {
        string[] xmlParts = xmlText.Split(" ")
            .Where(x => x.Contains("="))
            .Select(x => x.Trim())
            .Where(x => !string.IsNullOrWhiteSpace(x))
            .ToArray();

        string[] xmlKeysOfInterest =
        {
            "IterationDelay", "Repetitions", "UncagingLaserPower", "TriggerCount", "AsyncSyncFrequency",
            "InitialDelay", "InterPointDelay", "SpiralRevolutions", "IsSpiral", "SpiralSizeInMicrons"
        };

        List<string> summaryLines = new();
        foreach (string part in xmlParts)
        {
            string key = part.Split("=")[0];
            string value = part.Split("\"")[1];
            if (xmlKeysOfInterest.Contains(key))
                summaryLines.Add($"XML {key}: {value}");
        }

        string[] envKeysOfInterest =
        {
            "Name", "Duration", "SpiralSize", "SpiralRevolutions",
        };

        foreach (string line in envText.Split("\n"))
        {
            if (!line.Contains("<PVGalvoPoint "))
                continue;

            foreach (string kvp in line.Split(" ").Where(x => x.Contains("=")))
            {
                string[] pair = kvp.Split("=");
                string key = pair[0];
                string value = pair[1].Trim('"');
                if (envKeysOfInterest.Contains(key))
                    summaryLines.Add($"ENV {key}: {value}");
            }
        }

        string[] uniqueLines = summaryLines.Distinct().ToArray();

        return string.Join(Environment.NewLine, uniqueLines);
    }
}
