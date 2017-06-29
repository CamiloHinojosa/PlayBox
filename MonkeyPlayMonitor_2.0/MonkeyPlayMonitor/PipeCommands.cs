namespace PlayBoxMonitor
{
    public class PipeCommands
    {
        public string Type { get; set; }
        public string Action { get; set; }
        public object Properties { get; set; }

        public PipeCommands(string Type,string Action,object Properties)//CHECK REFERENCE BECAUSE OF OBJECT
        {
            this.Type=Type;
            this.Action=Action;
            this.Properties=Properties;
        }

        public PipeCommands()
        { }
    }
}