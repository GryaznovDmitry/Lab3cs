namespace GryaznovLab3
{
    public enum ChangeInfo
    {
        ItemChanged,
        Add,
        Remove,
        Replace
    }

    public delegate void DataChangedEventHandler(object source, DataChangedEventArgs args);
    
    public class DataChangedEventArgs
    {
        public ChangeInfo changed { get; set; }
        public string info { get; set; }
        public DataChangedEventArgs(ChangeInfo ch, string str)
        {
            changed = ch;
            info = str;
        }
        public override string ToString()
        {
            return $"Change status: { changed } \nInformation: { info }\n\n";
        }
    }
}
