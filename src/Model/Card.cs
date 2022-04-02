namespace Academy.Model
{
    public class Card
    {
        public Card(int paramId, string title, string flipTitle,
                         string firstDesc, string secondDesc, string imagePath)
        {
            Id = paramId.ToString();
            Title = title;
            FlipTitle = flipTitle;
            FlipFirstDesc = firstDesc;
            FlipSecondDesc = secondDesc;
            ImagePath = imagePath;
        }

        public Card()
        {

        }
        public string Id { get; set; }
        public string? Title { get; set; }
        public string? FlipTitle { get; set; }
        public string? FlipFirstDesc { get; set; }
        public string? FlipSecondDesc { get; set; }
        public string? ImagePath { get; set; }
        public string? Tags { get; set; }
        public string? Levels { get; set; }
    }

}
