namespace EventHorizon.MappedFileQueues;

public class MappedFileQueueOptions
{
    /// <summary>
    /// The path to store the mapped files and other runtime data.
    /// </summary>
    public required string StorePath { get; set; }

    /// <summary>
    /// The size of each mapped file segment in bytes, may be adjusted to fit the data type.
    /// </summary>
    public required int SegmentSize { get; set; }
}