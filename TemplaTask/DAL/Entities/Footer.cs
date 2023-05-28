namespace TemplaTask.DAL.Entities
{
    public class Footer : Entity
    {
        public ICollection<Contact> Contacts { get; set; }

        public ICollection<Downloads> Downloads { get; set; }

        public ICollection<SocialNetworks> SocialNetworks { get; set; }

        public string Designer { get; set; }

    }
}
