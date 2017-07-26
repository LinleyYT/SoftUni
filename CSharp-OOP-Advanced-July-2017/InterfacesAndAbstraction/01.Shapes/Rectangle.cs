using System;

public class Rectangle : IDrawable
{
    public Rectangle(int width, int height)
    {
        this.Width = width;
        this.Height = height;
    }

    private int width;
    private int height;

    public int Width
    {
        get { return this.width; }
        private set { this.width = value; }
    }

    public int Height
    {
        get { return this.height; }
        private set { this.height = value; }
    }

    public void Draw()
    {
        Drawline(this.Width, '*', '*');

        for (int i = 1; i < this.Height - 1; i++)
        {
            Drawline(this.Width, '*', ' ');
        }

        Drawline(this.Width, '*', '*');
    }

    private void Drawline(int width, char end, char mid)
    {
        Console.Write(end);

        for (int i = 1; i < width - 1; i++)
        {
            Console.Write(mid);
        }

        Console.WriteLine(end);
    }
}

