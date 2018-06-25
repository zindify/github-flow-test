var target = Argument("Target", "Build");

Task("Build")
    .Does(() =>
{
    DotNetCoreBuild("GitHubFlowTest.sln");
});

RunTarget(target);