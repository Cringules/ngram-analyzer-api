namespace Cringules.NGram.Api;

public class PlotData
{
    private readonly List<PlotPoint> _points;

    public IReadOnlyList<PlotPoint> Points => _points;

    public PlotData(IEnumerable<PlotPoint> points)
    {
        _points = points.OrderBy(point => point.Angle).ToList();
    }
}
