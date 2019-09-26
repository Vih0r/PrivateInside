using System.Collections.Generic;


namespace PrivateInside.Models
{
    public static class Repository
    {
        private static List<GuestResponse> responses =
            new List<GuestResponse>();
        public static IEnumerable<GuestResponse> Response
        {
            get
            {
                return responses;
            }
        }
        public static void AddResponse (GuestResponse response)
        {
            responses.Add(response);
        }

    }
}
