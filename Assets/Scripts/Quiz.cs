public class Quiz
{
    public string question;
    public int id;
    public string slc1;
    public string slc2;
    public string slc3;
    public string slc4;
    public string answer;

    public Quiz(int _id, string _question, string _slc1, string _slc2, string _slc3, string _slc4, string _answer)
    {
        id = _id;
        question = _question;
        slc1 = _slc1;
        slc2 = _slc2;
        slc3 = _slc3;
        slc4 = _slc4;
        answer = _answer;
    }

}