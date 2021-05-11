namespace dotnettest
{
    public class ArticleWithoutSmell
    {
        private IArticleState articleState;

        public string Name => articleState.Name;
        public string Text => articleState.Text;

        public ArticleWithoutSmell(string name, string text)
        {
            articleState = new NotReviewedArticleState(name, text);
        }
        
        public void Review(bool isAccepted, string review)
        {
            articleState = articleState.Review(isAccepted, review);
        }

        public void ChangeText(string newText)
        {
            articleState.ChangeText(newText);
        }

        public void Publish()
        {
            articleState = articleState.Publish();
        }

        public string GetState()
        {
            return articleState.GetType().ToString();
        }

        public string GetReviewText()
        {
            return articleState.GetReviewText();
        }
    }
}