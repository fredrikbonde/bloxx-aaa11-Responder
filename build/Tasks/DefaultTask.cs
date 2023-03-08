using Cake.Frosting;
using Overleaf.Cake.Frosting.Tasks;

namespace Build.Tasks;

[TaskName("Default")]
[IsDependentOn(typeof(CleanTask))]
[IsDependentOn(typeof(GitVersionTask))]
[IsDependentOn(typeof(SonarInitTask))]
[IsDependentOn(typeof(BuildTask))]
[IsDependentOn(typeof(ScanPackagesTask))]
[IsDependentOn(typeof(TestAndCoverTask))]
[IsDependentOn(typeof(PublishTask))]
[IsDependentOn(typeof(SonarEndTask))]
[IsDependentOn(typeof(PackageTask))]
[IsDependentOn(typeof(AwsCodeArtifactsPusherTask))]
[IsDependentOn(typeof(EcrDeployTask))]
[IsDependentOn(typeof(DockerBuildAndPushTask))]
[IsDependentOn(typeof(OctoDeployTask))]
public class DefaultTask : FrostingTask
{
}