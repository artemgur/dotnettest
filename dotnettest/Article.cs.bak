namespace dotnettest
{
    public class Article
    {
        public string Name;
        public string Text;
        public string ReviewerComment = null;
        public bool IsReviewed = false;
        public bool IsAccepted = false;
        public bool IsPublished = false;

        public Article(string name, string text)
        {
            Name = name;
            text = text;
        }

        public void Review(bool isAccepted, string review)
        {
            IsAccepted = isAccepted;
            ReviewerComment = review;
        }
    }
}