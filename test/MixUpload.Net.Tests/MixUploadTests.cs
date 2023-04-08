﻿namespace MixUpload.Net.Tests
{
    public class MixUploadTests
    {
        [Fact]
        public async Task TestMixUploadClient()
        {
            var client = new MixUploadClient();
            var r = await client.SearchAsync("scooter");
            Assert.NotEmpty(r);
        }
    }
}
