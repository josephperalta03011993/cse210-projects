using System;

class Program
{
    static void Main(string[] args)
    {
        List<Scripture> scriptures = new List<Scripture>
        {
            // D&C 6:36 Look unto me in every thought; doubt not, fear not.
            new Scripture(new Reference("D&C", 6, 36), "Look unto me in every thought; doubt not, fear not."),
            new Scripture(new Reference("D&C", 1, 37, 38), "37 Search these commandments, for they are true and faithful, " +
                "and the prophecies and promises which are in them shall all be fulfilled. 38 What I the Lord have spoken, " + 
                "I have spoken, and I excuse not myself; and though the heavens and the earth pass away, my word shall not " + 
                "pass away, but shall all be fulfilled, whether by mine own voice or by the voice of my servants, it is the same."),
        };

        Random random = new Random();
        Scripture currentScripture = scriptures[random.Next(scriptures.Count)];
       
        while(!currentScripture.IsCompletelyHidden())
        {

            // Clear the console
            Console.Clear();
            Console.WriteLine(currentScripture.GetDisplayText());
            Console.WriteLine();
            Console.WriteLine("Press enter to continue or type 'quit' to finish:");
            string userInput = Console.ReadLine();

            if(userInput.ToLower() == "quit")
            {
                break;
            }
            else 
            {
                // get the total unhidden words
                int unhiddenWordCount = currentScripture.GetUnhiddenWordCount();
                int wordsToHide = Math.Min(3, unhiddenWordCount);
                int randNum = new Random().Next(1, wordsToHide + 1);

                currentScripture.HideRandomWords(randNum);
            }

            Console.Clear();
            Console.WriteLine("All words are hidden! Great job memorizing the scripture!");
        }
        
    }
}