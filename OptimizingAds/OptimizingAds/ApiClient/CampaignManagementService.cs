using System.Collections.Generic;
using System.Linq;
using ApiClient.AdvertiserService;
using ApiClient.CampaignService;

namespace ApiClient
{
    public class CampaignManagementService
    {
        public static IDictionary<int, string> GetAdvertisers(string ticket)
        {
            var client = new AdvertiserServiceClient();
            return client.GetAdvertisers(ticket, new GetAdvertisersData())
                         .Select(p => new {p.Id, p.Name})
                         .ToDictionary(kvp => kvp.Id.Value, kvp => kvp.Name);
        }

        public static IDictionary<int, string> GetCampaigns(string ticket, int advertiserId)
        {
            var client = new CampaignServiceClient();
            return client.GetCampaigns(ticket, new GetCampaignsData
                                                   {
                                                       AdvertiserId = advertiserId
                                                   })
                         .Select(p => new {p.Id, p.Name})
                         .ToDictionary(kvp => kvp.Id.Value, kvp => kvp.Name);
        }
    }
}
