namespace worksheet_eight_behavioural_design_patterns
{
    /// <summary>
    /// This is just a dummy class rather than using a real class - a mock.
    /// </summary>
    public class File
    {
        private string _fileName;
        private string _type;
        private string _location;
        public File(string fileName, string type, string location)
        {
            _fileName = fileName;
            _type = type;
            _location = location;
        }

        public string FileName => _fileName;

        public string Type => _type;

        public string Location => _location;
    }
}