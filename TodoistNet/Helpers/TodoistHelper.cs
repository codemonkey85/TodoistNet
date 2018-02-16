using System;
using System.Diagnostics;
using System.Threading.Tasks;
using Todoist.Net;
using Todoist.Net.Models;

namespace TodoistNetTest.Helpers
{
    public static class TodoistHelper
    {
        public static ITodoistClient Client;

        public static void Initialize(string apiToken)
        {
            if (string.IsNullOrEmpty(apiToken) || string.IsNullOrWhiteSpace(apiToken))
            {
                throw new Exception("No API Token provided!");
            }
            Client = new TodoistClient(apiToken);
        }

        public static async Task<Resources> GetResources(params ResourceType[] resourceTypes)
        {
            Resources resources = null;
            try
            {
                resources = await Client.GetResourcesAsync(resourceTypes);
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }
            return resources;
        }
    }
}