using System;
using System.Collections.Generic;
using System.Text;
using CsvHelper.Configuration.Attributes;

namespace Biz.Management.Parser
{
    public class BusinessData
    {
        [Name("age")]
        public int Age { get; set; }

        [Name("experience_years")]
        public int ExperienceYears { get; set; }

        [Name("experience_proxy")]
        public double ExperienceProxy { get; set; }

        [Name("monthly_ad_spend")]
        public double MonthlyAdSpend { get; set; }

        [Name("website_visits")]
        public int WebsiteVisits { get; set; }

        [Name("team_size")]
        public int TeamSize { get; set; }

        [Name("customer_rating")]
        public double CustomerRating { get; set; }

        [Name("region")]
        public string Region { get; set; } = string.Empty;

        [Name("business_type")]
        public string BusinessType { get; set; } = string.Empty;

        [Name("subscription_plan")]
        public string SubscriptionPlan { get; set; } = string.Empty;

        [Name("noise_feature_1")]
        public double NoiseFeature1 { get; set; }

        [Name("noise_feature_2")]
        public double NoiseFeature2 { get; set; }

        [Name("annual_revenue")]
        public double AnnualRevenue { get; set; }
    }
}
