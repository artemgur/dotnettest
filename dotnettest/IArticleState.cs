namespace dotnettest
{
    public interface IArticleState
    {
        public string Name { get; }
        public string Text { get; }

        public IArticleState Review(bool isAccepted, string review);

        public void ChangeText(string newText);

        public IArticleState Publish();

        public string GetReviewText();
    }
}