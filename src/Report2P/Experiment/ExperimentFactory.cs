namespace Report2P.Experiment;

internal static class ExperimentFactory
{
    public static IExperiment? GetExperiment(string folder2p)
    {
        PVXML.IScan? scan = PVXML.ScanFactory.FromPVFolder(folder2p);

        if (scan is null)
            return null;

        if (scan is PVXML.ScanTypes.LineScan linescan)
        {
            return linescan.HasUncagingData
                ? new LinescanWithUncaging(folder2p)
                : new LinescanWithoutUncaging(folder2p);
        }

        if (scan is PVXML.ScanTypes.SingleImage)
            return new SingleImage(folder2p);

        if (scan is PVXML.ScanTypes.MarkPoints)
            return new MarkPoints(folder2p);

        if (scan is PVXML.ScanTypes.ZSeries)
            return new ZSeries(folder2p);

        if (scan is PVXML.ScanTypes.TSeries)
            return new TImageSeries(folder2p);

        if (scan is PVXML.ScanTypes.TZSeries)
            return new TStackSeries(folder2p);

        return null;
    }
}
