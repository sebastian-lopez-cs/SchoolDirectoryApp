# School Directory Dashboard

A Blazor Web Application that consumes data from the Edutots School API and presents school information through a searchable, interactive and responsive user interface.

This project was developed for CA1 in BSC30926 Full-Stack Development.

## Features

- Retrieves school data from the Edutots School API
- Deserializes JSON data into C# models
- Displays school information using reusable Blazor components
- Real-time school search by name
- School details view using `EventCallback`
- Loading state while API data is being retrieved
- Error handling for failed API requests
- A-Z and Z-A sorting
- Refresh button to retrieve the latest API data
- School statistics showing total schools and filtered results
- Responsive Bootstrap layout
- Custom autumn-themed user interface

## Technologies Used

- C#
- .NET 10
- ASP.NET Core
- Blazor Web App
- Blazor Interactive Server
- Razor Components
- HttpClient
- LINQ
- Bootstrap
- HTML
- CSS
- Git
- GitHub

## API

The application uses the Edutots School API:

https://edutots.net/api/school

The API data is retrieved in `SchoolService.cs` using `HttpClient` and deserialized into a `List<School>`.

## Project Structure

```text
SchoolDirectoryApp
│
├── Models
│   └── School.cs
│
├── Services
│   └── SchoolService.cs
│
├── Components
│   ├── SchoolCard.razor
│   ├── SchoolDetails.razor
│   └── Pages
│       └── Schools.razor
│
├── Screenshots
│   ├── school-list.png
│   ├── search.png
│   ├── school-details.png
│   ├── loading.png
│   └── error.png
│
├── wwwroot
│   └── app.css
│
└── Program.cs