namespace attributes
{
    internal class ContactDebugDisplay
    {
        private readonly Contact _contact;
        public string UpperName => _contact.FirstName.ToUpperInvariant();
        public string AgeInHex => _contact.AgeInYears.ToString("X");
        public ContactDebugDisplay(Contact contact)
        {
            _contact = contact;
        }
    }
}