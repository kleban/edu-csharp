using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConfrencePlanner.Models
{
    public class ConferenceManager
    {
        private List<Speaker> speakers;
        private List<Report> reports;

        public ConferenceManager()
        {
            _initSpeackers();
            _initReports();
        }

       public List<Position> Positions = new List<Position>
{
    new Position { Id = 1, Name = "Research Assistant" },
    new Position { Id = 2, Name = "Postdoctoral Fellow" },
    new Position { Id = 3, Name = "Junior Researcher" },
    new Position { Id = 4, Name = "Senior Researcher" },
    new Position { Id = 5, Name = "Research Analyst" },
    new Position { Id = 6, Name = "Research Scientist" },
    new Position { Id = 7, Name = "Principal Investigator" },
    new Position { Id = 8, Name = "Data Scientist" },
    new Position { Id = 9, Name = "Lab Coordinator" },
    new Position { Id = 10, Name = "Visiting Scholar" }
};


        List<string> reportTitles = new List<string>
            {
                "Economic Modeling in the Age of Big Data",
                "Cybernetic Control Systems in National Economies",
                "Predictive Analytics for Economic Stability",
                "Systems Thinking in Economic Policy Design",
                "Modeling Supply Chains with Cybernetic Feedback",
                "Simulation of Macroeconomic Processes",
                "Digital Twins in Economic Forecasting",
                "Adaptive Algorithms in Economic Decision-Making",
                "AI-Based Economic Scenario Planning",
                "Cybersecurity Risks in Digital Economies"
            };
        private void _initReports()
        {
            reports = new List<Report>();
            DateTime startDate = new DateTime(2025, 6, 1, 9, 0, 0);

            var rand = new Random();

            foreach (var t in reportTitles)
            {
                int duration = rand.Next(1, 5) * 10;
                var r = new Report
                {
                    Title = t,
                    Speaker = speakers[rand.Next(0, speakers.Count)],
                    DateAndTime = startDate,
                    DurationMin = duration
                };
                reports.Add(r);
                startDate = startDate.AddMinutes(duration + 10);
            }

        }

        public List<Speaker> Speakers
        {
            get { return speakers; }
        }

        public List<Report> Reports
        {
            get { return reports; }
        }

        private void _initSpeackers()
        {
            speakers = new List<Speaker>
            {
                new Speaker { FullName = "Alice Johnson", Position = Positions[0], Org = "Tech University", Email = "alice.johnson@techuni.edu" },
                new Speaker { FullName = "Bob Smith", Position = Positions[1],Org = "DataCorp", Email = "bob.smith@datacorp.com" },
                new Speaker { FullName = "Carla Martinez",Position = Positions[2], Org = "Open Science Lab", Email = "carla.m@osl.org" },
                new Speaker { FullName = "Daniel Chen", Position = Positions[4],Org = "AI Solutions", Email = "daniel.chen@aisolutions.ai" },
                new Speaker { FullName = "Eva Petrova",Position = Positions[0], Org = "Kyiv Tech Hub", Email = "eva.petrova@kth.ua" },
                new Speaker { FullName = "Frank Müller",Position = Positions[3], Org = "Uni Stuttgart", Email = "frank.mueller@unistuttgart.de" }
            };
        }

        internal void AddSpeaker(Speaker speaker)
        {
            speakers.Add(speaker);
        }
    }
}
