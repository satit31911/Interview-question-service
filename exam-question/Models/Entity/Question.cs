using System.ComponentModel.DataAnnotations.Schema;

[Table("questions")]
public class Question
{
    [Column("id")]
    public int Id { get; set; }
    [Column("questiontext")]
    public string QuestionText { get; set; } = null!;
    [Column("choice1")]
    public string Choice1 { get; set; } = null!;
    [Column("choice2")]
    public string Choice2 { get; set; } = null!;
    [Column("choice3")]
    public string Choice3 { get; set; } = null!;
    [Column("choice4")]
    public string Choice4 { get; set; } = null!;
}