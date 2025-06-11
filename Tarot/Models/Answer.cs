using System;

namespace Tarot.Models;

public class Answer
{
    public int AnswerId { get; set;}
    public string AnswerImageUrl { get; set;} = string.Empty;
    public string AnswerName { get; set;} = string.Empty;

    public string AnswerDesp { get; set;} = string.Empty;

    public int QuestionId { get; set;}
}
