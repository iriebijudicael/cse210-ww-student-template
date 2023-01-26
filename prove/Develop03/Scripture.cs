using System;

class Scripture
{
    private string scriptureText;
    private Reference scriptureReference;

    public Scripture (Reference _scriptureReference, string _scriptureText)
    {
       scriptureText = _scriptureText;
       scriptureReference = _scriptureReference;
    }

    public string GetToString ()
    {
        return string.Format("{0}", scriptureText);
    }
}