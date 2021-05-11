namespace dotnettest
{
    public class Article
    {
        private IArticleState ArticleState;

        public string Name => ArticleState.Name;
        public string Text => ArticleState.Text;

        public Article(string name, string text)
        {
            ArticleState = new NotReviewedArticleState(name, text);
        }
        
        public void Review(bool isAccepted, string review)
        {
            ArticleState = ArticleState.Review(isAccepted, review);
        }

        public void ChangeText(string newText)
        {
            ArticleState.ChangeText(newText);
        }

        public void Publish()
        {
            ArticleState = ArticleState.Publish();
        }

        public string GetState()
        {
            return ArticleState.GetType().ToString();
        }
    }
}