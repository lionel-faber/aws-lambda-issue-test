using Amazon.Lambda.Core;

// Assembly attribute to enable the Lambda function's JSON input to be converted into a .NET class.
[assembly: LambdaSerializer(typeof(Amazon.Lambda.Serialization.SystemTextJson.DefaultLambdaJsonSerializer))]

namespace Lambda;

public class Function
{
    public static async Task<string> TestFunctionAsync(ILambdaContext context)
    {
        await Task.Delay(TimeSpan.FromMinutes(6));
        return "ok";
    }
}
