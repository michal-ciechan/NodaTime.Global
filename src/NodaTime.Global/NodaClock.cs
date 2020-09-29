namespace NodaTime.Global
{
    public static class NodaClock
    {
        public static IClock Default { get; set; } = SystemClock.Instance;
    }
}