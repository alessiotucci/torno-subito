// Create a new instance of the WebApplication builder
// The 'WebApplication' class provides a convenient way to configure and build an ASP.NET Core application.
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// The 'Services' property of the builder provides access to the service container.
// The 'AddRazorPages' method adds Razor Pages services to the service container.
// Razor Pages services provide functionality for working with Razor Pages in the application.
builder.Services.AddRazorPages();

// Build the application.
// The 'Build' method creates and configures the application using the configuration specified by the builder.
// It returns an instance of 'WebApplication' that represents the built application.
var app = builder.Build();

// Configure the HTTP request pipeline.
// The request pipeline is a series of middleware components that process HTTP requests and responses.
// Middleware components are responsible for handling various aspects of the request/response pipeline.
// In this case, the code configures the pipeline with the following middleware components:

// Check if the application is running in development mode.
if (!app.Environment.IsDevelopment())
{
    // UseExceptionHandler: This middleware catches any unhandled exceptions that occur during request processing and generates an appropriate error response.
    app.UseExceptionHandler("/Error");

    // UseHsts: This middleware adds HTTP Strict Transport Security (HSTS) headers to responses.
    // HSTS is a security feature that instructs browsers to only access the application over HTTPS for a specified period of time.
    // This line of code sets the default HSTS value to 30 days.
    // Note: In a production scenario, you may want to change this value accordingly.
    app.UseHsts();
}

// UseHttpsRedirection: This middleware redirects HTTP requests to HTTPS.
// It ensures that all requests are made over a secure HTTPS connection.
app.UseHttpsRedirection();

// UseStaticFiles: This middleware serves static files (e.g., CSS, JavaScript, images) from the wwwroot directory.
app.UseStaticFiles();

// UseRouting: This middleware sets up routing for the application.
// It examines the request's URL and determines which action or page to execute based on the URL pattern.
app.UseRouting();

// UseAuthorization: This middleware sets up authorization for the application.
// It is responsible for enforcing access control policies and determining if a user is authorized to perform a specific action.
app.UseAuthorization();

// MapRazorPages: This middleware maps requests to Razor Pages.
// It routes requests to the appropriate Razor Page based on the URL pattern.
app.MapRazorPages();

// Run the application.
// The 'Run' method starts the application and begins listening for incoming HTTP requests.
// Once the application starts, it continues processing requests until it is stopped or terminated.
app.Run();

