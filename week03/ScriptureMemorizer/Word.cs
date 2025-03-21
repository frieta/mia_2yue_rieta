class Word
{
    private string _originalText; // original word text
    private string _hiddenText; // hidden version (underscores)
    private bool _hidden; // flag to check if it's hidden

    public Word(string text)
    {
        _originalText = text;
        _hiddenText = new string('_', text.Length); // replace word with underscores
        _hidden = false;
    }

    public void Hide()
    {
        _hidden = true;
    }

    public bool IsHidden()
    {
        return _hidden;
    }

    public override string ToString()
    {
        return _hidden ? _hiddenText : _originalText; // show either hidden or original word
    }

    public string GetOriginalText()
    {
        return _originalText;
    }
}
