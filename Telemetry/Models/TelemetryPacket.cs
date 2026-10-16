namespace Telemetry.models;

// we're going to send packets through from our C codebase. This is going to be base for us to work with and think about

public record TelemetryPacket(
  string Sensor,
  double Value  
);