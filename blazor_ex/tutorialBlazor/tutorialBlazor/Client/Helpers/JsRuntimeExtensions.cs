using Microsoft.JSInterop;
// using this MIcrosoft libraries
namespace tutorialBlazor.Client.Helpers
{
    // all the method are static
    public static class JsRuntimeExtensions
    {
        public static ValueTask<bool> Confirm(this IJSRuntime jsRuntime, string message)
        {
            return jsRuntime.InvokeAsync<bool>("confirm", message);
        }
    
    public static void Test(this IJSRuntime jSRuntime, string message)
        {
            jSRuntime.InvokeVoidAsync("test", message);
        }
    public static ValueTask Alert(this IJSRuntime jsRuntime, string message)
        {
            return jsRuntime.InvokeVoidAsync("alert", message);
        }
    
   
    }

}
