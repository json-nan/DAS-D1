namespace DAS_D1.Classes
{
    internal class ProgrammingLanguageItem
    {
        public string Name { get; set; }
        public string Developers { get; set; }
        public string Extensions { get; set; }
        public string YearOfCreation { get; set; }
        public string OS { get; set; }
        public string Paradigm { get; set; }
        public string LastVersion { get; set; }
        public string License { get; set; }

        public ProgrammingLanguageItem(string name, string developers, string extensions, string yearOfCreation, string oS, string paradigm, string lastVersion, string license)
        {
            Name = name;
            Developers = developers;
            Extensions = extensions;
            YearOfCreation = yearOfCreation;
            OS = oS;
            Paradigm = paradigm;
            LastVersion = lastVersion;
            License = license;
        }
    }
}
