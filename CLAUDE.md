# CLAUDE.md

This file provides guidance to Claude Code (claude.ai/code) when working with code in this repository.

## Project Overview

Wintakam is a .NET MAUI (Multi-platform App UI) cross-platform application targeting:
- Android (net9.0-android, minimum API 21)
- iOS (net9.0-ios, minimum iOS 15.0)
- macOS Catalyst (net9.0-maccatalyst, minimum 15.0)
- Windows (net9.0-windows10.0.19041.0, minimum 10.0.17763.0)
- Tizen (net9.0-tizen, minimum 6.5) - optional, commented out by default

The project uses .NET 9.0 with C# nullable reference types enabled and implicit usings.

## Build and Run Commands

### Building the project
```bash
# Build for all platforms (on Windows)
dotnet build Wintakam.csproj

# Build for specific platform
dotnet build Wintakam.csproj -f net9.0-android
dotnet build Wintakam.csproj -f net9.0-ios
dotnet build Wintakam.csproj -f net9.0-maccatalyst
dotnet build Wintakam.csproj -f net9.0-windows10.0.19041.0

# Clean build artifacts
dotnet clean Wintakam.csproj
```

### Running the application
```bash
# Run on Windows
dotnet run -f net9.0-windows10.0.19041.0

# Run on Android (requires emulator or connected device)
dotnet run -f net9.0-android

# Run on iOS simulator (requires macOS)
dotnet run -f net9.0-ios
```

### Restore dependencies
```bash
dotnet restore Wintakam.csproj
```

## Architecture

### Application Entry Point
- **MauiProgram.cs**: Application startup configuration. Configures the MauiApp builder, registers fonts (OpenSans-Regular, OpenSans-Semibold), and adds debug logging in DEBUG builds.

### Application Structure
- **App.xaml / App.xaml.cs**: Main application class. Creates the main window with AppShell as the root.
- **AppShell.xaml / AppShell.xaml.cs**: Shell navigation container with flyout behavior. Defines the navigation structure and routes. Currently contains a single ShellContent pointing to MainPage.
- **MainPage.xaml / MainPage.xaml.cs**: Default home page with a counter button example.

### Platform-Specific Code
Platform-specific implementations are located in the `Platforms/` directory:
- `Platforms/Android/`: Android-specific code (MainActivity.cs, MainApplication.cs)
- `Platforms/iOS/`: iOS-specific code (AppDelegate.cs, Program.cs)
- `Platforms/MacCatalyst/`: macOS Catalyst-specific code (AppDelegate.cs, Program.cs)
- `Platforms/Windows/`: Windows-specific code (App.xaml, App.xaml.cs)
- `Platforms/Tizen/`: Tizen-specific code (Main.cs)

### Resources
- `Resources/AppIcon/`: Application icons (appicon.svg, appiconfg.svg)
- `Resources/Splash/`: Splash screen assets (splash.svg)
- `Resources/Images/`: Image resources (including dotnet_bot.png)
- `Resources/Fonts/`: Custom fonts (OpenSans, FluentUI)
- `Resources/Styles/`: XAML style definitions (Colors.xaml, Styles.xaml)
- `Resources/Raw/`: Raw assets included via MauiAsset

### Navigation
Navigation is managed through the Shell pattern (AppShell.xaml). To add new pages:
1. Create a new ContentPage (e.g., NewPage.xaml and NewPage.xaml.cs)
2. Register the page in AppShell.xaml as a ShellContent or register routes in AppShell.xaml.cs using `Routing.RegisterRoute()`
3. Navigate using `Shell.Current.GoToAsync("routename")`

### Dependency Injection
Services should be registered in MauiProgram.cs using the builder.Services collection:
```csharp
builder.Services.AddSingleton<IMyService, MyService>();
builder.Services.AddTransient<MyPage>();
builder.Services.AddTransient<MyViewModel>();
```

Pages and ViewModels can then receive dependencies via constructor injection.

## Key NuGet Packages
- Microsoft.Maui.Controls: Core MAUI framework
- Microsoft.Extensions.Logging.Debug: Debug logging provider

## Important Notes
- The project uses Single Project architecture (SingleProject=true), meaning all platforms share the same project file
- ImplicitUsings are enabled, so common namespaces are automatically imported
- Nullable reference types are enabled project-wide
- Windows packaging type is set to None (unpackaged app) - to publish to Microsoft Store, this needs to be changed
- Application ID is "com.companyname.wintakam" - should be changed for production
