using Ana_CV_page.Models;
using Azure.Storage.Blobs;
using Microsoft.Extensions.Configuration;
using System.Text;
using System.Text.Json;

namespace api.Services;

public class CvStorageService
{
    private const string ContainerName = "cv-data";
    private const string BlobName = "cv.json";

    private readonly BlobContainerClient _container;

    public CvStorageService(IConfiguration configuration)
    {
        var connectionString =
            configuration["CvStorageConnectionString"]
            ?? "UseDevelopmentStorage=true";

        var blobService = new BlobServiceClient(connectionString);

        _container = blobService.GetBlobContainerClient(ContainerName);
    }

    public async Task<CvData?> GetCvAsync()
    {
        await _container.CreateIfNotExistsAsync();

        var blob = _container.GetBlobClient(BlobName);

        if (!await blob.ExistsAsync())
        {
            var filePath = Path.Combine(
                AppContext.BaseDirectory,
                "cv.json");

            var initialJson = await File.ReadAllTextAsync(filePath);

            using var stream = new MemoryStream(
                Encoding.UTF8.GetBytes(initialJson));

            await blob.UploadAsync(stream);
        }

        var download = await blob.DownloadContentAsync();

        return JsonSerializer.Deserialize<CvData>(
            download.Value.Content.ToString(),
            new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            });
    }

    public async Task SaveCvAsync(CvData cv)
    {
        await _container.CreateIfNotExistsAsync();

        var blob = _container.GetBlobClient(BlobName);

        var json = JsonSerializer.Serialize(
            cv,
            new JsonSerializerOptions
            {
                WriteIndented = true
            });

        using var stream = new MemoryStream(
            Encoding.UTF8.GetBytes(json));

        await blob.UploadAsync(
            stream,
            overwrite: true);
    }
}