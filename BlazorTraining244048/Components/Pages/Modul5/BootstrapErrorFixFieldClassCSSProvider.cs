using Microsoft.AspNetCore.Components.Forms;

namespace BlazorTraining244048.Components.Pages.Modul5
{
    public class BootstrapErrorFixFieldClassCSSProvider : FieldCssClassProvider
    {
        public override string GetFieldCssClass(EditContext editContext, in FieldIdentifier fieldIdentifier)
        {
           bool isInValid= editContext.GetValidationMessages(fieldIdentifier).Any();

            return isInValid ? "is-invalid" : "is-valid";
        }
    }
}
