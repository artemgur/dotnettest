namespace dotnettest
{
    public class NotAcceptedArticleState: IArticleState
    {
        public NotAcceptedArticleState(string name, string text, string reviewerComment)
        {
            Name = name;
            Text = text;
            ReviewerComment = reviewerComment;
        }

        public string Name { get; private set; }
        public string Text { get; private set; }
        public string ReviewerComment { get; private set; }

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
            return ReviewerComment;
        }
    }
}