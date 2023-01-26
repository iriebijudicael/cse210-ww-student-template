using System;

class PassageMemorizer
{
    private Scripture passage;
    private List<string> scriptureTextList;

    public PassageMemorizer (Scripture _passage)
    {
        passage = _passage;
        scriptureTextList = new List<string>();
        changeTextToList();
    }

    public void changeTextToList()
    {
        scriptureTextList = passage.GetToString().Split(' ').ToList();
    }

    public void hideWordFromList()
    {
        int getWordsRemove = new Random().Next(3, 5);
        int wordsRemoved = 0;

        do
        {
            int randomIndex = new Random().Next(0, scriptureTextList.Count());

            if (scriptureTextList[randomIndex].Contains('_') == false)
            {
               scriptureTextList[ randomIndex] = new string('_', scriptureTextList[randomIndex].Length);
               wordsRemoved++;
            }
        } while (wordsRemoved != getWordsRemove);
    }

    public string GetToString()
    {
        return string.Join(' ', scriptureTextList);
    }

    public bool WordLeft()
    {
        bool value = false;

        foreach (string word  in scriptureTextList)
        {
           if (word.Contains('_') == false)
           {
               value = true;
               break;
           } 
        }
        return value;
    } 
}