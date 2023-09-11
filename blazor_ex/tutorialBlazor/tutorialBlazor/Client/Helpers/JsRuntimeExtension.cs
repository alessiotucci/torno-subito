using Microsoft.JSInterop;

namespace tutorialBlazor.Client.Helpers
{
    public static class JsRuntimeExtension
    {
        public static ValueTask<bool> Confirm(this IJSRuntime jSRuntime, string message)
        {
          return   jSRuntime.InvokeAsync<bool>("confirm", message);

        }
        public static void Test(this IJSRuntime jSRuntime, string message)
        {
            jSRuntime.InvokeVoidAsync("test", message);
        }
        public static ValueTask Alert(this IJSRuntime jSRuntime, string message)
        {
         return    jSRuntime.InvokeVoidAsync("alert", message);

        }
    }
}
