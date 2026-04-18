namespace Yukari.Core.Sources
{
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = false)]
    public sealed class ComicSourceMetadataAttribute : Attribute
    {
        public string Name { get; }
        public string Version { get; }
        public string? LogoUrl { get; }
        public string? Description { get; }

        public ComicSourceMetadataAttribute(
            string name,
            string version,
            string? logoUrl = null,
            string? description = null
        )
        {
            Name = name;
            Version = version;
            LogoUrl = logoUrl;
            Description = description;
        }
    }
}
