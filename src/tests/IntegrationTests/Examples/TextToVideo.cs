/*
order: 10
title: Text-to-video
slug: text-to-video

Create a PixVerse text-to-video generation request and poll the generated video result.
*/

namespace PixVerse.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task Example_TextToVideo()
    {
        using var client = GetAuthenticatedClient();

        var response = await client.CreateTextToVideoAsync(new TextToVideoRequest
        {
            Prompt = "A calm cinematic shot of clouds moving over a mountain lake.",
            Model = PixVerseModel.V6,
            Duration = 5,
            Quality = VideoQuality.x540p,
            AspectRatio = AspectRatio.x16_9,
            MotionMode = "normal",
        });

        response.Resp?.VideoId.Should().BeGreaterThan(0);
    }
}
