using System.Text;

namespace MailClient
{
    public class MailBox
    {
        public int Capacity { get; set; }
        public List<Mail> Inbox { get; set; }
        public List<Mail> Archive { get; set; }
        public MailBox(int capacity)
        {
            Capacity = capacity;
            Inbox = new List<Mail>();
            Archive = new List<Mail>();
        }
        public void IncomingMail(Mail mail)
        {
            if (Inbox.Count < Capacity)
            {
                Inbox.Add(mail);
            }    
        }
        public bool DeleteMail(string sender)
        {
            Mail deleteMail = Inbox.FirstOrDefault(x => x.Sender == sender);
            if (deleteMail == null)
            {
                return false;
            }

            return Inbox.Remove(deleteMail);
        }
        public int ArchiveInboxMessages()
        {
            int count = Inbox.Count;
            Archive = Inbox;
            Inbox = new List<Mail>();

            return count;
        }
        public string GetLongestMessage()
        {
            //string longestMail = Inbox.Max(x => x.Body);
            Mail longestMail = Inbox.OrderByDescending(x => x.Body).FirstOrDefault();

            return longestMail.ToString();
        }
        public string InboxView()
        {
            StringBuilder inbox = new();

            inbox.AppendLine("Inbox:");

            foreach (Mail mail in Inbox)
            {
                inbox.AppendLine(mail.ToString());
            }
            return inbox.ToString().TrimEnd();
        }
    }
}
