using MixUpload.Net.Responses;

namespace MixUpload.Net;

public interface IMixUploadClient
{
    Task<List<MixUpladResponse>> SearchAsync(string keyword);
}