using Syncfusion.Blazor;
 
    public class SyncfusionLocalizer : ISyncfusionStringLocalizer
    {
        public string GetText(string key)
        {
            return this.ResourceManager.GetString(key);
        }
        public System.Resources.ResourceManager ResourceManager
        {
            get
            {                
                return ElectronicVotingToos.Resources.SfResources.ResourceManager;
            }
        }
    }
 