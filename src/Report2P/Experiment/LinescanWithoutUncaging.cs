namespace Report2P.Experiment;

internal class LinescanWithoutUncaging : Linescan, IExperiment
{
    public override string ExperimentType => "Linescan";

    public LinescanWithoutUncaging(string folder)
    {
        Path = System.IO.Path.GetFullPath(folder);
        Scan = new PVXML.ScanTypes.LineScan(folder);
    }
}
