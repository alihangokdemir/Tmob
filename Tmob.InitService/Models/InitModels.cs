namespace InitService.Models
{
    public class InitModels
    {
       
        public bool needsUpdate { get; set; }
        

        public enum Mode
        {
            Test,
            Production
        };
        


    }
}