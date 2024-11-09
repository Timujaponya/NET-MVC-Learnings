using Microsoft.AspNetCore.Razor.TagHelpers;

namespace MeetingApp.TagHelpers
{
    public class ButtonTagHelper : TagHelper
    {
        public string ButtonText { get; set; } = "CLICK"; //set a default text value
        //public string ButtonText { get; set; }
        public string ButtonType { get; set; } = "button";

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "button";    // Set the output tag to <button>
            output.Attributes.SetAttribute("type", ButtonType);
            output.Content.SetContent(ButtonText);
            output.Attributes.SetAttribute("class", "btn btn-dark");
        }
    }
}