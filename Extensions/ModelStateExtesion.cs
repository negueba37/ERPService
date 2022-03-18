using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace ERPService.Extensions
{
    public static class ModelStateExtesion
    {
        public static List<string> GetErrors(this ModelStateDictionary modelState) {
            var errors = new List<string>();
            foreach (var item in modelState.Values)
            {
                foreach (var value in item.Errors)
                {
                    errors.Add(value.ErrorMessage);
                }

            }
            
            return errors;                
        }
    }
}
