namespace DotNet.Testcontainers.Clients
{
  using System.Collections.Generic;
  using System.Threading;
  using System.Threading.Tasks;
  using Docker.DotNet.Models;
  using DotNet.Testcontainers.Containers.Configurations;
  using DotNet.Testcontainers.Containers.OutputConsumers;

  internal interface IDockerContainerOperations : IHasListOperations<ContainerListResponse>
  {
    Task<long> GetExitCode(string id, CancellationToken ct = default);

    Task StartAsync(string id, CancellationToken ct = default);

    Task StopAsync(string id, CancellationToken ct = default);

    Task RemoveAsync(string id, CancellationToken ct = default);

    Task AttachAsync(string id, IOutputConsumer outputConsumer, CancellationToken ct = default);

    Task<long> ExecAsync(string id, IList<string> command, CancellationToken ct = default);

    Task<string> RunAsync(ITestcontainersConfiguration configuration, CancellationToken ct = default);
  }
}
