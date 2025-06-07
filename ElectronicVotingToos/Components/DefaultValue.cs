using Syncfusion.Blazor.Popups;

namespace ElectronicVotingToos.Components
{
    public class DefaultValue
    {
        //public Query LocalDataQuery = new Query().Take(10);
        public string DialogContent { get; set; } = "آیا مطمئن هستید که می خواهید این مورد را برای همیشه حذف کنید؟";
        public DialogOptions dialogOptions()
        {
            return new DialogOptions()
            {
                AnimationSettings = new DialogAnimationOptions() { Effect = DialogEffect.Zoom },
                PrimaryButtonOptions = new DialogButtonOptions() { Content = "تایید", IconCss = "e-icons e-check" },
                CancelButtonOptions = new DialogButtonOptions() { Content = "لغو", IconCss = "e-icons e-close" },
                Position = new PositionDataModel() { Y = "top", X = "center" },
            };
        }
    }
}
