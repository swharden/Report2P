namespace Report2P.Experiment;

public interface IExperiment
{
    string ExperimentType { get; }
    string Path { get; }
    string AutoanalysisFolder { get; }
    string Details { get; }
    ResultsFiles[] GetResultFiles();
    DateTime DateTime { get; }
    public void Analyze(bool clear = false);
}