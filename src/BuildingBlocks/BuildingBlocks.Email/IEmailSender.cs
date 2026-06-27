using System;
using System.Collections.Generic;
using System.Text;

namespace BuildingBlocks.Email;
public interface IEmailSender
{
}
public class EmailObject
{
    public EmailObject(string receiverEmail, string subject, string mailBody)
    {
        //ReceiverEmail = receiverEmail.NotBeNullOrWhiteSpace();
        //Subject = subject.NotBeNullOrWhiteSpace();
        //MailBody = mailBody.NotBeNull();
    }

    public EmailObject(string receiverEmail, string senderEmail, string subject, string mailBody)
    {
        //ReceiverEmail = receiverEmail.NotBeNullOrWhiteSpace();
        //Subject = subject.NotBeNullOrWhiteSpace();
        //MailBody = mailBody.NotBeNull();
        //SenderEmail = senderEmail.NotBeNullOrWhiteSpace();
    }

    public string ReceiverEmail { get; }

    public string SenderEmail { get; } = default!;

    public string Subject { get; }

    public string MailBody { get; }
}
