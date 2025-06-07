namespace ElectronicVotingToos.Components
{
    public class ToastOptions
    {
        public string Title { get; set; }
        public string Content { get; set; }

        public string CssClass { get; set; }
        public string Icon { get; set; }
        public bool EnableRtl { get; set; }
        public int Timeout { get; set; }
        public bool ShowCloseButton { get; set; }
        public bool ShowProgressBar { get; set; }
    }
}