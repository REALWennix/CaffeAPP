namespace BlazorApp1.Models
{
    // Models/Invitation.cs
    public class Invitation
    {
        public int ID { get; set; }
        public int InviterId { get; set; }
        public int InviteeId { get; set; }
        public string QrCode { get; set; }
        public DateTime Expiration { get; set; }

        public Person Inviter { get; set; }
        public Person Invitee { get; set; }
    }

}
