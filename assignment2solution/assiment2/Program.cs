using System.Text;

namespace assiment2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //السؤال الاول
            Console.WriteLine("-------Question 1--");

            string title = "clean code";
            string upperTitle = title.ToUpper();

            Console.WriteLine(title);
            Console.WriteLine(upperTitle);

            //السؤال الثاني
            Console.WriteLine("-------Question 2--");

            string book1 = "Clean Code";
            string book2 = "Clean Code";

            bool isSameReference = ReferenceEquals(book1, book2);
            Console.WriteLine(isSameReference);


            //السؤال الثالث
            Console.WriteLine("-------Question 3--");

            StringBuilder sb = new StringBuilder();
            sb.Append("Book List");
            sb.Append(" - Updated");

            Console.WriteLine(sb.ToString());

            //السؤال الرابع
            Console.WriteLine("-------Question 4--");

            sb.Replace("Book List", "Library");
            Console.WriteLine(sb.ToString());

            //السؤال الخامس
            Console.WriteLine("-------Question 5--");

            string title2 = "Clean Code";
            int pages = 464;

            string sentence = "Book: " + title2 + ", Pages: " + pages;
            Console.WriteLine(sentence);

            //السؤال السادس
            Console.WriteLine("-------Question 6--");

            string sentence2 = $"Book: {title}, Pages: {pages}";
            Console.WriteLine(sentence2);

            //السؤال السابع
            Console.WriteLine("-------Question 7--");

            string sentence3 = string.Format("Book: {0}, Pages: {1}", title, pages);
            Console.WriteLine(sentence3);

            //السؤال التامن
            Console.WriteLine("------------Question 8------");

            int pages2 = 464;
            if(pages2 > 300)
            {
                Console.WriteLine("Long Book");
            }
            else
            {
                Console.WriteLine("Short Book");
            }

            //السؤال التاسع
            Console.WriteLine("------------Question 9------");

            int pagess = 464;
            bool isAvailable = true;

            if (pagess > 300 && isAvailable)
            {
                Console.WriteLine("You can borrow this book");
            }

            //السؤال العاشر
            Console.WriteLine("------------Question 10------");

            string title3 = "Refactoring";

            switch (title3)
            {
                case "Clean Code":
                    Console.WriteLine("Great choice!");
                    break;
                case "Refactoring":
                    Console.WriteLine("Nice pick!");
                    break;
                default:
                    Console.WriteLine("Never heard of it");
                    break;
            }

            //السؤال ال 11 
            Console.WriteLine("------------Question 11------");

            int page = 464;
            string sizeLabel = (page > 300) ? "Long Book" : "Short Book";
            Console.WriteLine(sizeLabel);

            //السؤال ال12
            Console.WriteLine("------------Question 12------");

            string[] books = { "Clean Code","The Pragmatic Programmer","Refactoring" };

            for (int i = 0; i < books.Length; i++)
            {
                Console.WriteLine($"{i + 1}.{books[i]}");
            }

            //السؤال ال13 
            Console.WriteLine("------------Question 13------");

            //string[] books = { "Clean Code", "The Pragmatic Programmer", "Refactoring" };

            int x = 0;

            while (x < books.Length)
            {
                Console.WriteLine(books[x]);
                x++;
            }

            //السؤال ال14
            Console.WriteLine("---------Question 14-----");

            int c = 0;

            do
            {
                Console.WriteLine("Checking book...");
                c++;
            } while (c < 3);

            //السؤال ال15
            Console.WriteLine("------------Question 15-------");

            //string[] books = { "Clean Code", "The Pragmatic Programmer", "Refactoring" };

            foreach (string book in books)
            {
                Console.WriteLine(book);
            }
            //السؤال ال16
            Console.WriteLine("------------Question 16------");

            //string[] books = { "Clean Code", "The Pragmatic Programmer", "Refactoring" };

            foreach (string book in books)
            {
                Console.WriteLine(book);

                if (book == "Refactoring")
                {
                    break;
                }
            }
            //السؤال ال17
            Console.WriteLine("------------Question 17------");

            //string[] books = { "Clean Code", "The Pragmatic Programmer", "Refactoring" };

            foreach (string book in books)
            {
                if (book == "The Pragmatic Programmer")
                {
                    continue;
                }

                Console.WriteLine(book);
            }

            //السؤال ال18
            Console.WriteLine("------------Question 18------");

            //string[] books = { "Clean Code", "The Pragmatic Programmer", "Refactoring" };

            PrintFirstBook();
            void PrintFirstBook()

            {
                if (books == null || books.Length == 0)
                {
                    return;
                }

                Console.WriteLine(books[0]);
            }

        }
    }
}

