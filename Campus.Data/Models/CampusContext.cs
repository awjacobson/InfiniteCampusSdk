using System.Data.Entity;

namespace Campus.Data.Models
{
    public class CampusContext : DbContext
    {
        public CampusContext() : base("name=Campus")
        {
        }

        public virtual DbSet<CampusAttribute> CampusAttributes { get; set; }
        public virtual DbSet<CampusDictionary> CampusDictionaries { get; set; }
        public virtual DbSet<Contact> Contacts { get; set; }
        public virtual DbSet<CustomStudent> CustomStudents { get; set; }
        public virtual DbSet<Identity> Identities { get; set; }
        public virtual DbSet<Person> People { get; set; }
        public virtual DbSet<Survey> Surveys { get; set; }
        public virtual DbSet<SurveyPage> SurveyPages { get; set; }
        public virtual DbSet<SurveyQuestion> SurveyQuestions { get; set; }
        public virtual DbSet<SurveyQuestionAnswer> SurveyQuestionAnswers { get; set; }
        public virtual DbSet<SurveyQuestionResponse> SurveyQuestionResponses { get; set; }
        public virtual DbSet<SurveyResponse> SurveyResponses { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Person>()
                .HasOptional(person => person.Contact)
                .WithRequired(contact => contact.Person);
        }
    }
}
