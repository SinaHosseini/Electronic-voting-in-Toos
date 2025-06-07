namespace ElectronicVotingToos.Components
{
    public class ToastService
    {
        public event Action<ToastOptions> ToastInstance;

        public void ShowToastError(string Content = null)
        {
            Content = (string.IsNullOrEmpty(Content)) ? "عملیات شما با خطا مواجه شد." : Content;
            ToastOptions Options = new ToastOptions
            {
                Title = "خطا!",
                Content = Content,
                CssClass = "e-toast-danger",
                Icon = "e-error toast-icons",
                EnableRtl = true,
                Timeout = 5000,
                ShowCloseButton = true,
                ShowProgressBar = true
            };
            this.ToastInstance.Invoke(Options);
        }
        public void ShowToastSuccess(string Content = null)
        {
            Content = (string.IsNullOrEmpty(Content)) ? "عملیات شما با موفقیت انجام شد." : Content;
            ToastOptions Options = new ToastOptions
            {
                Title = "موفق!",
                Content = Content,
                CssClass = "e-toast-success",
                Icon = "e-success toast-icons",
                EnableRtl = true,
                Timeout = 5000,
                ShowCloseButton = true,
                ShowProgressBar = true
            };
            this.ToastInstance.Invoke(Options);
        }
        public void ShowToastWarning(string Content = null)
        {
            Content = (string.IsNullOrEmpty(Content)) ? "مشکلی در اتصال شبکه شما وجود داشت." : Content;
            ToastOptions Options = new ToastOptions
            {
                Title = "توجه!",
                Content = Content,
                CssClass = "e-toast-warning",
                Icon = "e-warning  toast-icons",
                EnableRtl = true,
                Timeout = 5000,
                ShowCloseButton = true,
                ShowProgressBar = true
            };
            this.ToastInstance.Invoke(Options);
        }
        public void ShowToastInformation(string Content = null)
        {
            Content = (string.IsNullOrEmpty(Content)) ? "لطفا نظرات را با دقت بخوانید." : Content;
            ToastOptions Options = new ToastOptions
            {
                Title = "اطلاعات!",
                Content = Content,
                CssClass = "e-toast-info",
                Icon = "e-info toast-icons",
                EnableRtl = true,
                Timeout = 5000,
                ShowCloseButton = true,
                ShowProgressBar = true
            };
            this.ToastInstance.Invoke(Options);
        }
    }
}