using System;
public class Scripture
{
    private Reference _reference; // stores my reference like D&C 1:2
    private List<Word> _words; // this will hold the list of words in my verse

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = new List<Word>(); 

        // split the words and create word objects
        foreach (string word in text.Split(' '))
        {
            _words.Add(new Word(word));
        }
    }

    public void HideRandomWords(int numberToHide)
    {
        Random random = new Random();
        for(int i = 0; i < numberToHide; i++)
        {
            // Find a random word that is not yet hidden
            Word wordToHide;
            do 
            {
                int randomIndex = random.Next(_words.Count);
                wordToHide = _words[randomIndex];
            } while (wordToHide.IsHidden());

            wordToHide.Hide();
        }
    }

    // Lets get the full text including the hidden words
    public string GetDisplayText()
    {
        string referenceText = _reference.GetDisplayText();
        string wordText = "";

        foreach (Word word in _words)
        {
            wordText += word.GetDisplayText() + " ";
        }

        return referenceText + " " + wordText.Trim();
    }

    public bool IsCompletelyHidden()
    {
        foreach (Word word in _words)
        {
            if(!word.IsHidden())
            {
                return false;
            }
        }

        return true;
    }

    public int GetUnhiddenWordCount()
    {
        int count = 0;

        foreach(var word in _words)
        {
            if(!word.IsHidden())
            {
                count++;
            }
        }
        return count;
    }
}