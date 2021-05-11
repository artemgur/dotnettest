namespace dotnettest
{
    public interface IArticleState
    {
        public IArticleState Review(bool isAccepted, string review);

        public void ChangeText(string newText);

        public IArticleState Publish();
    }
}