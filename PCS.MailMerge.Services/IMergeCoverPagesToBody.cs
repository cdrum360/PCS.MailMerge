namespace PCS.MailMerge.Services
{
    public interface IMergeCoverPagesToBody
    {
        string bodyPageIdentifier { get; set; }
        string coverPageIdentifier { get; set; }

        void Merge(string sourceDirectory);
    }
}