using api.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.Functions.Worker;

namespace api;

public class MediaUploadFunction
{
    private const long MaxFileSize = 5 * 1024 * 1024;

    private readonly MediaStorageService _mediaStorage;

    public MediaUploadFunction(MediaStorageService mediaStorage)
    {
        _mediaStorage = mediaStorage;
    }

    [Function("profile-image")]
    public async Task<IActionResult> Run(
        [HttpTrigger(
            AuthorizationLevel.Anonymous,
            "post",
            Route = "media/profile-image")]
        HttpRequest req)
    {
        if (!req.HasFormContentType)
        {
            return new BadRequestObjectResult("Expected multipart form data.");
        }

        var form = await req.ReadFormAsync();
        var file = form.Files.GetFile("file");

        if (file is null || file.Length == 0)
        {
            return new BadRequestObjectResult("No image file was provided.");
        }

        if (file.Length > MaxFileSize)
        {
            return new BadRequestObjectResult("Image must be 5 MB or smaller.");
        }

        var extension = Path.GetExtension(file.FileName).ToLowerInvariant();

        var allowedTypes = new Dictionary<string, string>
        {
            [".png"] = "image/png",
            [".jpg"] = "image/jpeg",
            [".jpeg"] = "image/jpeg",
            [".webp"] = "image/webp"
        };

        if (!allowedTypes.TryGetValue(extension, out var contentType))
        {
            return new BadRequestObjectResult(
                "Only PNG, JPG, JPEG and WEBP images are allowed.");
        }

        await using var stream = file.OpenReadStream();

        var imageUrl = await _mediaStorage.UploadProfileImageAsync(
            stream,
            contentType,
            extension);

        return new OkObjectResult(new
        {
            url = imageUrl
        });
    }
}