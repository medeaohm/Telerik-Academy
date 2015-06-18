namespace VersionAttribute
{
    using System;

    [AttributeUsage(AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Class | AttributeTargets.Interface)]

    public class VersionAttribute : Attribute
    {
        public string Version { get; set; }
        public string Name { get; set; }
        public Type Component { get; set; }

        public VersionAttribute(Type component, string name, string version)
        {
            this.Version = version;
            this.Component = component;
            this.Name = name;
        }

        public enum Type
        {
            Struct,
            Method,
            Class,
            Interface,
        }
    }
}
