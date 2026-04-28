using Soenneker.TestHosts.Unit;
using Soenneker.Tests.HostedUnit;

namespace Soenneker.PostHog.Runners.OpenApiClient.Tests;

[ClassDataSource<UnitTestHost>(Shared = SharedType.PerTestSession)]
public sealed class PostHogOpenApiClientRunnerTests : HostedUnitTest
{
    public PostHogOpenApiClientRunnerTests(UnitTestHost host) : base(host)
    {
    }

    [Test]
    public void Default()
    {

    }
}
