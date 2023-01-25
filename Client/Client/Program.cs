// See https://aka.ms/new-console-template for more information

using Amazon.Lambda;
using Amazon.Lambda.Model;

var request = new InvokeRequest
{
    FunctionName = "lambda-name-here",
    InvocationType = InvocationType.RequestResponse
};
var client = new AmazonLambdaClient();
var result = await client.InvokeAsync(request);
if (result.StatusCode == 200)
{
    using var stream = new StreamReader(result.Payload);
    Console.WriteLine(await stream.ReadToEndAsync());
}
else
{
    Console.WriteLine(result.FunctionError);
}
