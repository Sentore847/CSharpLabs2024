using System;

namespace BookApp
{
    class Title
    {
        private string title;

        public Title(string title)
        {
            this.title = title;
        }

        public string TitleName
        {
            get { return title; }
        }

        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Title: " + TitleName);
            Console.ResetColor();
        }
    }

    class Author
    {
        private string author;

        public string AuthorName
        {
            get { return author; }
            set { author = value; }
        }

        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Author: " + AuthorName);
            Console.ResetColor();
        }
    }

    class Content
    {
        private string content;

        public string BookContent
        {
            get { return content; }
            set { content = value; }
        }

        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Content: " + BookContent);
            Console.ResetColor();
        }
    }

    class Book
    {
        private Title title;
        private Author author = new Author();
        private Content content = new Content();

        public Book(string titleName)
        {
            title = new Title(titleName);
        }

        public Title BookTitle
        {
            get { return title; }
        }

        public Author BookAuthor
        {
            get { return author; }
        }

        public Content BookContent
        {
            get { return content; }
        }

        public void Show()
        {
            title.Show();
            author.Show();
            content.Show();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Book book = new Book("The Great Gatsby");
            book.BookAuthor.AuthorName = "F. Scott Fitzgerald";
            book.BookContent.BookContent = "A novel set in the 1920s about Jay Gatsby...";

            book.Show();

            book.BookAuthor.AuthorName = "New Author";
            book.BookContent.BookContent = "Updated content...";

            book.Show();
        }
    }
}
