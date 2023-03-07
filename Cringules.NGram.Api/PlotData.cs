using System.Text.Json.Serialization;

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

    /// <summary>
    /// Constructs the diffractogram plot data instance from data points. This constructor is used by JSON deserializer.
    /// </summary>
    /// <param name="points">A list of data points to construct the data from.</param>
    [JsonConstructor]
    public PlotData(IReadOnlyList<PlotPoint> points) : this((IEnumerable<PlotPoint>) points)
    {
    }
}
