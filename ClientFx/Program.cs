
using ClientFx.ExchangeServiceReference;
using System;

namespace ClientFx
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("rpc");
            ExchangeServicePortTypeClient client = new ExchangeServicePortTypeClient();
            
            var resp = ((ExchangeServicePortType)client).AcceptSharedCalendarInvite(new AcceptSharedCalendarInviteRequest { });
            Console.WriteLine(resp.AcceptSharedCalendarInviteResponse1.NewCalendarEntryId.Id);

            var resp2 = ((ExchangeServicePortType)client).ActivateSharingInvitation(new ActivateSharingInvitationRequest { });
            Console.WriteLine(resp2.ActivateSharingInvitationResponse1.SuggestedCalendarName);

            Console.ReadLine();
        }
    }
}
