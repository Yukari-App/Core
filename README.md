<div align="center">
  <h1>⚙️ Yukari.Core</h1>
</div>

<div align="center">
  
  ![NuGet Version](https://img.shields.io/nuget/v/Yukari.Core?style=for-the-badge&logo=nuget&label=NuGet%20Package&color=0956CC&link=https%3A%2F%2Fwww.nuget.org%2Fpackages%2FYukari.Core)
  ![GitHub last commit](https://img.shields.io/github/last-commit/Yukari-App/Core?style=for-the-badge&color=0956CC)
  ![GitHub repo size](https://img.shields.io/github/repo-size/Yukari-App/Core?style=for-the-badge&color=0956CC)
</div>

<div align="center">
  <h2>📖 Overview</h2>

**Yukari.Core** is the central library of **contracts and data models** for the Yukari ecosystem.

It defines the `IComicSource` interface and all the necessary templates (`Comic`, `Chapter`, `ChapterPage`, `Filter`, etc.) that must be implemented by **comic plugins/sources**.

The main application **[Yukari](https://github.com/Yukari-App/Yukari)** (a modern manga, webtoon, and comic book reader for Windows, built on WinUI 3 + .NET) dynamically loads these plugins to search, list, and read content from different websites and services without needing to modify the main code.

</div>

<div align="center">
  <h2>✍️ How to Create a ComicSource</h2>
</div>

- Create a new **Class Library** project (.NET 10)
- Install the package:

```xml
  <PackageReference Include="Yukari.Core" Version="*" />
```

- Decorate your class with `[ComicSourceMetadata]` and implement `IComicSource`:

```cs
  [ComicSourceMetadata(
      name: "My Source",
      version: "1.0.0+core2.3.0", // Match your Yukari.Core version
      ReleasesPage: "https://github.com/MyName/Yukari.Plugin.MySource/releases",
      logoUrl: null,
      description: "Example comic source"
  )]
  public class MyComicSource : IComicSource
  {
      public IReadOnlyList<Filter> Filters => Array.Empty<Filter>();
      public IReadOnlyDictionary<string, string> Languages =>
          new Dictionary<string, string> { ["en"] = "English" };

      public Task<IReadOnlyList<Comic>> SearchAsync(
          string query,
          IReadOnlyDictionary<string, IReadOnlyList<string>> filters,
          int page = 1,
          CancellationToken ct = default
      )
      {
          // Implement search logic here
          return Task.FromResult<IReadOnlyList<Comic>>(Array.Empty<Comic>());
      }

      // Implement remaining methods: GetTrendingAsync, GetDetailsAsync,
      // GetAllChaptersAsync, GetChapterPagesAsync...

      public ValueTask DisposeAsync() => ValueTask.CompletedTask;
  }
```

> **Note:** The `[ComicSourceMetadata]` attribute is required. Yukari reads plugin metadata (name, version, logo, description) directly from the attribute without instantiating the class, so omitting it will cause the plugin to fail to load.

- Build → get the `.dll`
- Publish as a new repo in the org (or your own), with Releases containing the DLL.
  Current examples:
  - [Plugin.MangaDex](https://github.com/Yukari-App/Plugin.MangaDex)
  - [Plugin.WeebCentral](https://github.com/Yukari-App/Plugin.WeebCentral)
  - [Plugin.ComicK](https://github.com/Yukari-App/Plugin.ComicK) (archived)  
    Browse all: [Yukari-App repositories → Plugin.\*](https://github.com/orgs/Yukari-App/repositories?q=Plugin+sort%3Aname-asc)

<div align="center">
  <h2>🗒️ Notes</h2>
</div>

- The `[ComicSourceMetadata]` attribute is the **only way** to declare plugin metadata — `Name`, `Version`, `LogoUrl` and `Description` are not part of `IComicSource`
- Use a single/shared `HttpClient` instance with proper User-Agent
- Consider static lazy initialization for **Filters** and **Languages**
- Respect **rate limits** and implement proper **error handling**
- Return **empty collections** or `null` instead of throwing when no data is found (when reasonable)
- All **async methods** should support `CancellationToken`
- **XML documentation** on **public members** is highly appreciated
- If your plugin depends on **third-party libraries**, merge them into a single `.dll` 
  using [ILRepack.Lib.MSBuild.Task](https://www.nuget.org/packages/ILRepack.Lib.MSBuild.Task). Make sure to **exclude** 
  `Yukari.Core` from the merge — including it would cause type identity conflicts 
  at runtime, since the host already loads its own copy of the assembly
- The reserved source name **"Local"** cannot be used as a plugin name — 
  Yukari uses it internally for local comics and will reject any plugin 
  that attempts to register with that name

<div align="center">
  <h2>🤝 Contributing</h2>
  
Contributions are welcome! You can help improve **Yukari.Core** in several ways:
</div>

- 🐛 **Report issues**: Found a bug or unexpected behavior? Open an [issue](../../issues) describing the problem.
- ✨ **Suggest features**: Have an idea to make **Yukari.Core** better? Share it in the issues tab.
- 🔧 **Submit pull requests**: Fix bugs, improve code quality, or add new features.

<div align="center">
  <h2>📜 License</h2>

This project is licensed under the **GPL-3.0**. See the [LICENSE](LICENSE) file for details.

</div>
