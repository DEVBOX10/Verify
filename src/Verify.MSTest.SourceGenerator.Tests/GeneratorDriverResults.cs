readonly record struct GeneratorDriverResults(GeneratorDriverResult FirstRun, GeneratorDriverResult CachedRun);

readonly record struct GeneratorDriverResult(GeneratorDriverRunResult RunResult, GeneratorDriverTimingInfo TimingInfo);