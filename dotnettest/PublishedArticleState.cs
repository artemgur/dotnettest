namespace dotnettest
{
    public class PublishedArticleState: IArticleState
    {
        public PublishedArticleState(string name, string text)
        {
            Name = name;
            Text = text;
        }

        public string Name { get; private set; }
        public string Text { get; private set; }

        public IArticleState Review(bool isAccepted, string review)
        {
            throw new System.InvalidOperationException();
        }

        public void ChangeText(string newText)
        {
            throw new System.InvalidOperationException();
        }

        public IArticleState Publish()
        {
            throw new System.InvalidOperationException();
        }

        public string GetReviewText()
        {
            throw new System.InvalidOperationException();
        }
    }
}