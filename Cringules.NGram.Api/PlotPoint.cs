namespace Cringules.NGram.Api;

/// <summary>
/// Represents a diffractogram plot data point.
/// </summary>
/// <param name="Angle">Angle in degrees.</param>
/// <param name="Intensity">Intensity in arbitrary units.</param>
public record PlotPoint(double Angle, double Intensity);
