namespace Report2P.Experiment;

internal class LinescanWithUncaging : Linescan, IExperiment
{
    public override string ExperimentType => "Uncaging Linescan";

    public LinescanWithUncaging(string folder)
    {
        Path = System.IO.Path.GetFullPath(folder);
        Scan = new PVXML.ScanTypes.LineScan(folder);
    }
}
