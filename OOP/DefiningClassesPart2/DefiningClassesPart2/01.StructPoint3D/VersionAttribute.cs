/*11. Create a [Version] attribute that can be applied to structures, classes, interfaces, enumerations and methods 
 * and holds a version in the format major.minor (e.g. 2.11). 
 * Apply the version attribute to a sample class and display its version at runtime.*/

namespace _01.StructPoint3D
{
    using System;

    [System.AttributeUsage(System.AttributeTargets.Class | System.AttributeTargets.Struct |
        System.AttributeTargets.Enum | System.AttributeTargets.Method)]
    public class VersionAttribute : Attribute
    {
        public string Version { get; private set; }

        public VersionAttribute(string version)
        {
            this.Version = version;
        }
    }
}
