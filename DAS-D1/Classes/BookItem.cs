namespace DAS_D1.Classes
{
    internal class BookItem
    {
        public string Name { get; set; }
        public string Author { get; set; }
        public string Gender { get; set; }
        public string SubGender { get; set; }
        public string Pages { get; set; }
        public string Protagonists { get; set; }
        public string Antagonists { get; set; }
        public string Argument { get; set; }

        public BookItem(string name, string author, string gender, string subGender, string pages, string protagonists, string antagonists, string argument)
        {
            Name = name;
            Author = author;
            Gender = gender;
            SubGender = subGender;
            Pages = pages;
            Protagonists = protagonists;
            Antagonists = antagonists;
            Argument = argument;
        }
    }
}
