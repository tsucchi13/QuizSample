public class Quiz
{
    public string question;
    public int id;
    public string[] choises;
    public string answer;

    public Quiz(int _id, string _question, string[] _choices, string _answer)
    {
        id = _id;
        question = _question;
        choises = _choices;
        answer = _answer;
    }
}
