using Candidates.DAL;
using Candidates.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Candidates.DAL
{
    public class CandidatesDBContext : DbContext
    {
        public CandidatesDBContext() : base("CandidatesAPIConnectionString")
        {
            this.Configuration.LazyLoadingEnabled = false;
            Database.SetInitializer<CandidatesDBContext>(new CandidateDBInitializer());
        }

        public DbSet<Candidate> Candidates { get; set; }
        public DbSet<Skill> Skills { get; set; }

    }

    internal class CandidateDBInitializer : CreateDatabaseIfNotExists<CandidatesDBContext>
    {
        public override void InitializeDatabase(CandidatesDBContext context)
        {
            KillProcesses(context.Database.Connection);
            base.InitializeDatabase(context);
        }

        protected override void Seed(CandidatesDBContext context)
        {
            generateFakeData(context);
            base.Seed(context);
        }
        
        private void generateFakeData(CandidatesDBContext context)
        {
            #region ListCandidates

            List<Candidate> candidates = new List<Candidate>()
            {
                 new Candidate() {
                    Id=100000,
                    Name="Sherlock Holmes",
                    Salary="\u0026pound; 60,000 p.a.",
                    MostRecentEmployment="Strategy Consultant",
                    MostRecentEmploymentDurationInYears= 2.5,
                    CurrentLocation= "London, N2",
                    Skills = new List<Skill>() {
                        new Skill("Deduction"),
                        new Skill("Observation"),
                        new Skill("Investigation"),
                        new Skill("Intuition"),
                        new Skill("Hat wearing")
                    }
                 },
                 new Candidate(){
                    Id=100001,
                    Name="Ian Blake",
                    Salary="\u0026pound; 35,000 p.a.",
                    MostRecentEmployment="Senior pricing manager",
                    MostRecentEmploymentDurationInYears= 1.5,
                    CurrentLocation= "London, E11",
                     Skills = new List<Skill>() {
                        new Skill("MS Office"),
                        new Skill("Visual Studio"),
                        new Skill("Maths"),
                        new Skill("Accountancy"),
                        new Skill("Dog grooming")
                     }
                },
                new Candidate(){
                    Id=100010,
                    Name="Kelly Clarkson",
                    Salary="Not specified",
                    MostRecentEmployment="Pricing Analyst",
                    MostRecentEmploymentDurationInYears= null,
                    CurrentLocation= "London, WC3",
                       Skills = new List<Skill>() {
                        new Skill("Pricing"),
                        new Skill("Analysis"),
                        new Skill("Hang gliding")
                     }
                },
                new Candidate() {
                    Id=100011,
                    Name="Ashley Troops",
                    Salary="\u0026pound;66,000 p.a.",
                    MostRecentEmployment="Pricing Expert",
                    MostRecentEmploymentDurationInYears= 5,
                    CurrentLocation= "Not specified",
                      Skills = new List<Skill>() {
                        new Skill("Pricing"),
                        new Skill("Statistical Analysis"),
                        new Skill("Linear Algebra"),
                        new Skill("Advanced scuba-diving"),
                     }
                },
                new Candidate() {
                    Id=100100,
                    Name="Billy Jones",
                    Salary="\u0026pound;29,000 p.a.",
                    MostRecentEmployment="Pricing Expert",
                    MostRecentEmploymentDurationInYears= 2,
                    CurrentLocation= "London SE4",
                      Skills = new List<Skill>() {
                        new Skill("MS Word"),
                        new Skill("Hiking"),
                    }
                },
                new Candidate(){
                    Id=100101,
                    Name="Diego Costa",
                    Salary="\u0026pound;58,000 p.a.",
                    MostRecentEmployment="Not specified",
                    MostRecentEmploymentDurationInYears= null,
                    CurrentLocation= "London SW2",
                      Skills = new List<Skill>() {
                        new Skill("Linux"),
                        new Skill("SQL"),
                        new Skill("C#"),
                        new Skill("Visual Studio"),
                     }
                },
                new Candidate(){
                    Id=100110,
                    Name="Jennifer Smith",
                    Salary="\u0026pound;44,000 p.a.",
                    MostRecentEmployment="Senior pricing expert",
                    MostRecentEmploymentDurationInYears= 1.5,
                    CurrentLocation= "London EC2",
                      Skills = new List<Skill>() {
                        new Skill("Consultancy"),
                        new Skill("Accountancy"),
                        new Skill("MS Calculator"),
                     }
                },
                new Candidate(){
                    Id=100111,
                    Name="Allistair Smith",
                    Salary="\u0026pound;38,000 p.a.",
                    MostRecentEmployment="Pricing consultant",
                    MostRecentEmploymentDurationInYears= 0.5,
                    CurrentLocation= "London E8",
                      Skills = new List<Skill>() {
                        new Skill("Differencial Equations"),
                        new Skill("Maths modeling"),
                        new Skill("Finance"),
                        new Skill("Skiing"),
                   }
                },
                new Candidate(){
                    Id=101000,
                    Name="James Patelidis",
                    Salary="\u0026pound;25,000 p.a.",
                    MostRecentEmployment="Junior pricing advisor",
                    MostRecentEmploymentDurationInYears= 1.5,
                    CurrentLocation= "Not specified",
                      Skills = new List<Skill>() {
                        new Skill("Advanced Maths"),
                        new Skill("Calculus"),
                        new Skill("Dancing"),
                    }
                },
                new Candidate(){
                    Id=101001,
                    Name="Johnie Walker",
                    Salary="\u0026pound;30,000 p.a.",
                    MostRecentEmployment="Senior Accountanct",
                    MostRecentEmploymentDurationInYears= 45,
                    CurrentLocation= "London N8",
                      Skills = new List<Skill>() {
                        new Skill("Accountancy"),
                        new Skill("AAT"),
                        new Skill("Investigation"),
                        new Skill("Skydiving"),
                     }
                }
            };

            #endregion

            foreach(Candidate c in candidates)
            {
               List<Skill> skillToAdd = new List<Skill>();
                for (int i=0;i<c.Skills.Count;i++)
                {
                    string name = c.Skills.ElementAt(i).Name;
                    var bddSkill = context.Skills.FirstOrDefault(sk => sk.Name == name);
                    if(bddSkill != null)
                    {
                        c.Skills.Remove(c.Skills.ElementAt(i));
                        skillToAdd.Add(bddSkill);
                    }
                    
                }
                foreach(Skill s in skillToAdd)
                {
                    c.Skills.Add(s);
                }
                context.Candidates.Add(c);
                context.SaveChanges();
            }

          
        }

        private void KillProcesses(DbConnection connection)
        {
            string sql = String.Format(@"
            USE master
            GO

            SET NOCOUNT ON
            DECLARE @DBName varchar(50)
            DECLARE @spidstr varchar(8000)
            DECLARE @ConnKilled smallint
            SET @ConnKilled=0
            SET @spidstr = ''

            Set @DBName = '{0}'
            IF db_id(@DBName) < 4
            BEGIN
            PRINT 'Connections to system databases cannot be killed'
            RETURN
            END
            SELECT @spidstr=coalesce(@spidstr,',' )+'kill '+convert(varchar, spid)+ '; '
            FROM master..sysprocesses WHERE dbid=db_id(@DBName)

            IF LEN(@spidstr) > 0
            BEGIN
            EXEC(@spidstr)
            SELECT @ConnKilled = COUNT(1)
            FROM master..sysprocesses WHERE dbid=db_id(@DBName)
            END", connection.Database);

            RunScript(connection, sql);
        }

        private void RunScript(DbConnection connection, string script)
        {
            try
            {
                script = String.Format(@"USE [{0}]
                GO
                {1}", connection.Database, script);

                if (connection.State != ConnectionState.Open)
                    connection.Open();

                Regex regex = new Regex(@"GO");
                string[] commands = regex.Split(script);

                for (int i = 0; i < commands.Length; i++)
                {
                    if (commands[i] != string.Empty)
                    {
                        using (DbCommand command = connection.CreateCommand())
                        {
                            command.CommandText = commands[i];
                            int rowAffected = command.ExecuteNonQuery();
                            command.Dispose();
                        }
                    }
                }
            }
            finally
            {
                connection.Close();
            }
        }
    }
}
