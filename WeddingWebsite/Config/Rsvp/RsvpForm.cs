using WeddingWebsite.Models.ConfigInterfaces;
using WeddingWebsite.Models.Rsvp;

namespace WeddingWebsite.Config.Rsvp;

public class RsvpForm : IRsvpForm
{
    public RsvpQuestions YesQuestions => new RsvpQuestions(
        [
            new RsvpQuestion(
                Title: "Will you be staying for the evening meal?",
                Description: null,
                Required: true,
                QuestionType: new RsvpQuestionType.Select(
                    DataColumn: new RsvpDataColumn(0, "Evening Meal"),
                    Options:
                    [
                        "Yes",
                        "No"
                    ],
                    OtherField: null
                )
            ),
            new RsvpQuestion(
                Title: "Please let us know of any dietary requirements you have so we can cater to your needs.",
                Description: "If you do not have any dietary requirements, please leave this field blank.",
                Required: false,
                QuestionType: new RsvpQuestionType.FreeText(new RsvpDataColumn(1, "Dietary Requirements"), 100, "Vegan, gluten free etc.")
            ),
            
            new RsvpQuestion(
                Title: "Extra comments or queries.",
                Description: null,
                Required: false,
                QuestionType: new RsvpQuestionType.FreeText(new RsvpDataColumn(2, "Extra Comments"), 300, "")
            )
        ],
        Validator: data =>
        {
            // Here you can add custom validation logic.
            return [];
        }
    );
    
    public RsvpQuestions NoQuestions => new RsvpQuestions(
    [
        new RsvpQuestion(
            Title: "We're sorry you can't make it! If you'd like to leave a message, you can do so below.",
            Description: null,
            Required: false,
            QuestionType: new RsvpQuestionType.FreeText(new RsvpDataColumn(0, "Reason"), 300)
        )
    ]);

    public DateTime? Deadline => new DateTime(2026, 6, 28);
    
    public bool LongAttendanceResponses => true;
}