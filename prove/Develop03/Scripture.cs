using System;
using System.Collections.Generic;

public class Scripture
{
    public Reference Reference { get; private set; }
    public string Text { get; private set; }
    private List<Word> Words;
    public bool IsFullyHidden => Words.TrueForAll(w => w.IsHidden);

    public Scripture(Reference reference, string text)
    {
        Reference = reference;
        Text = text;
        Words = new List<Word>();
        foreach (var word in (Reference.ToString() + ": " + text).Split(' '))
        {
            Words.Add(new Word(word));
        }
    }

    public void Display()
    {
        Console.Write(Reference + ": ");
        foreach (var word in Words)
        {
            Console.Write(word + " ");
        }
        Console.WriteLine();
    }

    public void HideWords()
    {
        Random rnd = new Random();
        int wordsToHide = rnd.Next(1, Words.Count / 4);  // Hides up to 25% of the words, randomly
        for (int i = 0; i < wordsToHide; i++)
        {
            Words[rnd.Next(Words.Count)].Hide();
        }
    }
}
