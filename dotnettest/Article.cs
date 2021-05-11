namespace dotnettest
{
    public class Article
    {
        private IArticleState ArticleState;

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
    }
}