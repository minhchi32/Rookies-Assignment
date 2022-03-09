namespace eCommerce.Backend.Common;
public interface IFileStorageService
{
    string GetFileUrl (string fileName);
    Task SaveFileAsync(Stream mediaBinaryStream, string fileName);
    Task DeleteFileAsync(string fileName);
}