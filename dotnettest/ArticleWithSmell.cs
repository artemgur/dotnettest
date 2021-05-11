using System;

namespace dotnettest
{
    public class ArticleWithSmell
    {
        public string Name { get; private set; }
        public string Text { get; private set; }
        //Temporary field
        public string ReviewerComment { get; private set; }
        public bool IsReviewed { get; private set; }
        public bool IsAccepted { get; private set; }
        public bool IsPublished { get; private set; }

        public Article(string name, string text)
        {
            Name = name;
            Text = text;
            IsPublished = false;
            ReviewerComment = null;
            IsReviewed = false;
            IsAccepted = false;
            IsPublished = false;
        }

        public void Review(bool isAccepted, string review)
        {
            if (IsPublished)
                throw new InvalidOperationException();
            IsReviewed = true;
            IsAccepted = isAccepted;
            ReviewerComment = review;
        }

        public void ChangeText(string newText)
        {
            if (IsAccepted || IsPublished)
                throw new InvalidOperationException();
            Text = newText;
        }

        public void Publish()
        {
            if (!IsAccepted)
                throw new InvalidOperationException();
            IsPublished = true;
        }
    }
}