namespace dotnettest
{
    public class NotReviewedArticleState: IArticleState
    {
        public NotReviewedArticleState(string name, string text)
        {
            Name = name;
            Text = text;
        }

        public string Name { get; private set; }
        public string Text { get; private set; }

        public IArticleState Review(bool isAccepted, string review)
        {
            if (isAccepted)
                return new AcceptedArticleState(Name, Text, review);
            return new NotAcceptedArticleState(Name, Text, review);
        }

        public void ChangeText(string newText)
        {
            Text = newText;
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