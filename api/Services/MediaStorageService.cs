using Azure.Storage.Blobs;
using Azure.Storage.Blobs.Models;
using Microsoft.Extensions.Configuration;

namespace api.Services;

public class MediaStorageService
{
    private const string ContainerName = "media";

    private readonly BlobContainerClient _container;

    public MediaStorageService(IConfiguration configuration)
    {
        var connectionString =
            configuration["CvStorageConnectionString"]
            ?? "UseDevelopmentStorage=true";

        var blobService = new BlobServiceClient(connectionString);

        _container = blobService.GetBlobContainerClient(ContainerName);
    }

    public async Task<string> UploadProfileImageAsync(
        Stream stream,
        string contentType,
        string extension)
    {
        await _container.CreateIfNotExistsAsync();

        var blobName = $"profile/ana-maria-{DateTime.UtcNow.Ticks}{extension}";
        var blob = _container.GetBlobClient(blobName);

        await blob.UploadAsync(stream, overwrite: true);

        await blob.SetHttpHeadersAsync(
            new BlobHttpHeaders
            {
                ContentType = contentType
            });

        return blob.Uri.ToString();
    }
}