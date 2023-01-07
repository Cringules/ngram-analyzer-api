namespace Cringules.NGram.Api;

/// <summary>
/// Represents a file source of diffractogram plot data. 
/// </summary>
public interface IFileDataSource
{
    /// <summary>
    /// Gets diffractogram plot data from file
    /// </summary>
    /// <param name="filename">Filename of the source file.</param>
    /// <returns>Diffractogram plot data obtained from the source file.</returns>
    public PlotData GetPlotData(string filename);
}
