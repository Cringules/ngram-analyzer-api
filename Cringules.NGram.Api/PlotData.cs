namespace Cringules.NGram.Api;

/// <summary>
/// Represents diffractogram plot data containing data points.
/// </summary>
public class PlotData
{
    /// <summary>
    /// List of data points.
    /// </summary>
    private readonly List<PlotPoint> _points;

    /// <summary>
    /// Gets the list of data points.
    /// </summary>
    public IReadOnlyList<PlotPoint> Points => _points;

    /// <summary>
    /// Constructs the diffractogram plot data instance from data points.
    /// </summary>
    /// <param name="points">An enumerable of data points to construct the data from.</param>
    public PlotData(IEnumerable<PlotPoint> points)
    {
        _points = points.OrderBy(point => point.Angle).ToList();
    }
}
