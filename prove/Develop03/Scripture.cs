using System;
using System.Collections.Generic;

public class Scripture
{
    public string Text { get; private set; }
    private List<Word> Words;
    public bool IsFullyHidden => Words.TrueForAll(w => w.IsHidden);

    public Scripture(string reference, string text)
    {
        Text = reference + ": " + text;
        Words = new List<Word>();
        foreach (var word in text.Split(' '))
        {
            Words.Add(new Word(word));
        }
    }

    public void Display()
    {
        foreach (var word in Words)
        {
            Console.Write(word + " ");
        }
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
