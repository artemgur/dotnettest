namespace dotnettest
{
    public class AcceptedArticleState: IArticleState
    {
        public AcceptedArticleState(string name, string text, string reviewerComment)
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
            throw new System.NotImplementedException();
        }

        public void ChangeText(string newText)
        {
            throw new System.NotImplementedException();
        }

        public IArticleState Publish()
        {
            return new PublishedArticleState(Name, Text);
        }
    }
}