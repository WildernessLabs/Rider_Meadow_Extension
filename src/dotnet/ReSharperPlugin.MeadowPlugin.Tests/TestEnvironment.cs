using System.Threading;
using JetBrains.Application.BuildScript.Application.Zones;
using JetBrains.ReSharper.Feature.Services;
using JetBrains.ReSharper.Psi.CSharp;
using JetBrains.ReSharper.TestFramework;
using JetBrains.TestFramework;
using JetBrains.TestFramework.Application.Zones;
using NUnit.Framework;

[assembly: Apartment(ApartmentState.STA)]

namespace RiderPlugin.MeadowPlugin.Tests
{
    [ZoneDefinition]
    public class MeadowPluginTestEnvironmentZone : ITestsEnvZone, IRequire<PsiFeatureTestZone>, IRequire<IMeadowPluginZone> { }

    [ZoneMarker]
    public class ZoneMarker : IRequire<ICodeEditingZone>, IRequire<ILanguageCSharpZone>, IRequire<MeadowPluginTestEnvironmentZone> { }

    [SetUpFixture]
    public class MeadowPluginTestsAssembly : ExtensionTestEnvironmentAssembly<MeadowPluginTestEnvironmentZone> { }
}
