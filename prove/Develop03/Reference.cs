namespace ScriptureMemorizer
{
    public class Reference
    {
        private string _reference;

        public Reference(string reference)
        {
            _reference = reference;
        }

        public string Display() // Method to display the reference
        {
            return _reference;
        }
    }
}
