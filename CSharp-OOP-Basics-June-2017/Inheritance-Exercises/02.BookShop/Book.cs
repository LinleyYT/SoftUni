﻿using System;
using System.Text;
using System.Text.RegularExpressions;

namespace _02.BookShop
{
    public class Book
    {
        public Book(string author, string title, decimal price)
        {
            this.Author = author;
            this.Title = title;
            this.Price = price;
        }

        private string title;

        public virtual string Title
        {
            get { return this.title; }
            protected set
            {
                if (value.Length < 3)
                {
                    throw new ArgumentException("Title not valid!");
                }

                this.title = value;
            }
        }

        private string author;

        public virtual string Author
        {
            get { return this.author; }
            protected set
            {
                if (Regex.IsMatch(value, @" (\d)"))
                {
                    throw new ArgumentException("Author not valid!");
                }

                this.author = value;
            }
        }

        private decimal price;

        public virtual decimal Price
        {
            get { return this.price; }
            protected set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Price not valid!");
                }

                this.price = value;
            }
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("Type: ").AppendLine(this.GetType().Name)
                .Append("Title: ").AppendLine(this.Title)
                .Append("Author: ").AppendLine(this.Author)
                .Append("Price: ").Append($"{this.Price:f1}")
                .AppendLine();

            return sb.ToString();
        }
    }
}