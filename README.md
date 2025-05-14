# SG01G02_MockReviewsAPI
  
This is an external project just to add a mock Azure Functions API to the main project.  
Nothing fancy. Mostly schmancy.  
  
---
  
## Project Structure
  
```css
SG01G02_MVC/
├── SG01G02_MVC/                                - Main project directory
│   ├── SG01G02_MVC.Application/
│   │   └── SG01G02_MVC.Application.csproj
│   ├── SG01G02_MVC.Domain/
│   │   └── SG01G02_MVC.Domain.csproj
│   ├── SG01G02_MVC.Infrastructure/
│   │   └── SG01G02_MVC.Infrastructure.csproj
│   ├── SG01G02_MVC.Web/
│   │   └── SG01G02_MVC.Web.csproj
│   ├── SG01G02_MVC.Tests/
│   │   └── SG01G02_MVC.Tests.csproj
│   │   └── SG01G02_MVC.Web.csproj
│   │
│   └── SG01G02_MVC.sln                         - Solution file
│
└── SG01G02_MockReviewsApi/                     - Azure Function App project directory
    └── SG01G02_MockReviewsApi.csproj

```
  
The `SG01G02_MockReviewsApi` project is included in the main solution (`.sln` file),  
which means it can share code, dependencies, and build processes with the MVC application projects.  
This structure keeps all related components organized and enables seamless development across both the MVC app and the Azure Functions API.  