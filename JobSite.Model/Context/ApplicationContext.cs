using System;
using System.Collections.Generic;
using System.Text;
using JobSite.Model.Common;
using JobSite.Model.Employer;
using JobSite.Model.Employer.Company_Details;
using JobSite.Model.Employer.PostedJob;
using JobSite.Model.JobSeeker;
using JobSite.Model.ViewModel;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace JobSite.Model.Context
{
    public class ApplicationContext : IdentityDbContext
    {
        public ApplicationContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<ApplicationUser> ApplicationUsers { get; set; }
        public DbSet<PersonalInformation> PersonalInformations { get; set; }
        public DbSet<Country> Countries  { get; set; }
        public DbSet<District>  Districts  { get; set; }
        public DbSet<EmploymentStatus>EmploymentStatuses  { get; set; }
        public DbSet<Gender>Genders  { get; set; }
        public DbSet<JobCategory>JobCategories  { get; set; }
        public DbSet<JobCategoryType>JobCategoryTypes  { get; set; }
        public DbSet<JobLevel>JobLevels  { get; set; }
        public DbSet<JobNature>JobNatures  { get; set; }
        public DbSet<MaritalStatus>MaritalStatuses  { get; set; }
        public DbSet<Nationality>Nationalities  { get; set; }
        public DbSet<Religion>Religions  { get; set; }
        public DbSet<Skill>Skills  { get; set; }
        public DbSet<Thana>Thanas  { get; set; }
        public DbSet<Address>Addresses  { get; set; }
        public DbSet<CompanyDetails>CompanyDetails  { get; set; }
        public DbSet<Contact>Contacts  { get; set; }
        public DbSet<IndustryType>IndustryTypes  { get; set; }
        public DbSet<IndustryTypeDetails> IndustryTypeDetails  { get; set; }
        public DbSet<Degree> Degrees  { get; set; }
        public DbSet<DegreeLevel> DegreeLevels  { get; set; }
        public DbSet<DegreeName> DegreeNames  { get; set; }
        public DbSet<EmploymentRequiredStatus> EmploymentRequiredStatuses  { get; set; }
        public DbSet<RequiredExperience> RequiredExperiences { get; set; }
        public DbSet<JobInformation>JobInformation  { get; set; }
        public DbSet<RequiredGender>RequiredGenders  { get; set; }
        public DbSet<RequiredJobLevel>RequiredJobLevels  { get; set; }
        public DbSet<RequiredPerson>RequiredPeople  { get; set; }
        public DbSet<Requirement> Requirements  { get; set; }
        public DbSet<RequiredSkill> RequiredSkills { get; set; }
        public DbSet<CareerInformation> CareerInformation  { get; set; }
        public DbSet<Education> Educations  { get; set; }
        public DbSet<EducationLevel> EducationLevels { get; set; }
        public DbSet<EducationTitle> EducationTitles { get; set; }
        public DbSet<Experience> Experiences { get; set; }
        public DbSet<JobSeekerPreferredLocation> JobSeekerPreferredLocations  { get; set; }
        public DbSet<JobSeekerProfessionalCertificate> JobSeekerProfessionalCertificates  { get; set; }
        public DbSet<JobSeekerTraining> JobSeekerTrainings  { get; set; }
        public DbSet<Language> Languages  { get; set; }
        public DbSet<LanguageProficiency> LanguageProficiencies  { get; set; }
        public DbSet<PersonalInformation> PersonalInformation  { get; set; }
        public DbSet<Photo> Photos  { get; set; }
        public DbSet<PreferredJobCategory> PreferredJobCategories  { get; set; }
        public DbSet<ProfessionalCertification> ProfessionalCertifications  { get; set; }
        public DbSet<References> References  { get; set; }
        public DbSet<JobSeekerSkill> JobSeekerSkill { get; set; }
        public DbSet<Training> Trainings  { get; set; }


    }
}
