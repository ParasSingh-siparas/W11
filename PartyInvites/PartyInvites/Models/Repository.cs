using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PartyInvites.Models
{
    public static class Repository
    {
        private static List<GuestResponse> _responses = new List<GuestResponse>();

        public static void AddResponse(GuestResponse response)
        {
            _responses.Add(response);
        }

        public static IEnumerable<GuestResponse> Responses
        {
            get { return _responses; }
        }
    }
}
