namespace P01.Stream_Progress
{
    public class StreamProgressInfo
    {
        private StreamableFile file;

        public StreamProgressInfo(StreamableFile file)
        {
            this.file = file;
        }

        public int CalculateCurrentPercent()
        {
            return (this.file.BytesSent * 100) / this.file.Length;
        }
    }
}
