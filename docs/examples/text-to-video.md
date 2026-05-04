# Text-to-video

Create a PixVerse text-to-video generation request and poll the generated video result.

This example assumes `using PixVerse;` is in scope and `apiKey` contains your PixVerse API key.

```csharp
using var client = new PixVerseClient(apiKey);

var response = await client.CreateTextToVideoAsync(new TextToVideoRequest
{
    Prompt = "A calm cinematic shot of clouds moving over a mountain lake.",
    Model = PixVerseModel.V6,
    Duration = 5,
    Quality = VideoQuality.x540p,
    AspectRatio = AspectRatio.x16_9,
    MotionMode = "normal",
});
```