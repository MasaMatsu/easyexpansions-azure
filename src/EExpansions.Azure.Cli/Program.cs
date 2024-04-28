using Azure.Identity;
using Azure.ResourceManager;

var client = new ArmClient(new AzureCliCredential());

var subscription = await client.GetDefaultSubscriptionAsync();
Console.WriteLine(subscription.Data.DisplayName);
