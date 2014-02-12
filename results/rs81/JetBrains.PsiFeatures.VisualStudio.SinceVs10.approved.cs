﻿[assembly: System.Runtime.InteropServices.ComVisibleAttribute(false)]
[assembly: System.Runtime.Versioning.TargetFrameworkAttribute(".NETFramework,Version=v4.0", FrameworkDisplayName=".NET Framework 4")]

namespace JetBrains.PsiFeatures.VisualStudio.SinceVs10.Documents.Markup.HighlightingSuppressor
{
    
    [JetBrains.ProjectModel.SolutionComponentAttribute()]
    public class VsHighlightingSuppressorNew
    {
        public VsHighlightingSuppressorNew(JetBrains.DataFlow.Lifetime lifetime, JetBrains.DocumentManagers.DocumentManager documentManager, JetBrains.ProjectModel.FileTypes.ProjectFileTypeServices projectFileTypeServices, JetBrains.TextControl.ITextControlManager manager, JetBrains.Application.Settings.ISettingsStore settingsStore, JetBrains.Util.Lazy.Lazy<Microsoft.VisualStudio.Text.Tagging.IViewTagAggregatorFactoryService> tagAggregatorFactoryService) { }
    }
}
namespace JetBrains.PsiFeatures.VisualStudio.SinceVs10.NuGet
{
    
    [JetBrains.VsIntegration.Application.WrapVsInterfacesAttribute()]
    public class ExposeNuGetServices : JetBrains.VsIntegration.Application.IExposeVsServices
    {
        public void Register(JetBrains.VsIntegration.Application.VsServiceProviderResolver.VsServiceMap map) { }
    }
    [JetBrains.ProjectModel.SolutionComponentAttribute()]
    public class NuGetSwaSupressor
    {
        public NuGetSwaSupressor(JetBrains.DataFlow.Lifetime lt, JetBrains.Application.IShellLocks locks, JetBrains.Util.Lazy.Lazy<NuGet.VisualStudio.IVsPackageInstallerEvents> events, JetBrains.ReSharper.Daemon.SolutionAnalysis.SolutionAnalysisManager swaManager, JetBrains.ProjectModel.ISolution solution, JetBrains.ReSharper.SolutionBuilder.SolutionBuilder builder, JetBrains.Application.Settings.ISettingsStore settingsStore, JetBrains.Util.ILogger logger) { }
    }
}