namespace eCommerce.Backend.Common;
public class FileStorageService : IFileStorageService
{
    readonly string userContentFolder;
    public FileStorageService(IWebHostEnvironment webHostEnvironment)
    {
        userContentFolder = Path.Combine(webHostEnvironment.WebRootPath, FolderConstant.imageFolderName);

    }
    public string GetFileUrl(string fileName)
    {
        return $"/{FolderConstant.imageFolderName}/{fileName}";
    }

    public async Task SaveFileAsync(Stream mediaBinaryStream, string fileName)
    {
        var filePath = Path.Combine(userContentFolder, fileName);
        using var output = new FileStream(filePath, FileMode.Create);
        await mediaBinaryStream.CopyToAsync(output);
    }

    public async Task DeleteFileAsync(string fileName)
    {
        var filePath = Path.Combine(userContentFolder, fileName);
        if (File.Exists(filePath))
            await Task.Run(() => File.Delete(filePath));
    }
}