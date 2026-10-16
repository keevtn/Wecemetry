namespace Telemetry.models;

public record TelemetrySample(
    DateTimeOffset Timestamp,
    double RPM,
    double WindSpeed,
    double Voltage,
    double Current,
    double PitchAngle
);
