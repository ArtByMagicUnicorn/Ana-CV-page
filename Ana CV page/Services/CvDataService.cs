using Ana_CV_page.Models;

namespace Ana_CV_page.Services;

public class CvDataService
{
    private CvData? _cv;
    public CvData GetCv()
    {
        return _cv ??= new CvData
        {
            Profile = new Profile
            {
                FirstName = "Ana M",
                LastName = "Gheorghe",

                ProfessionalTitle =
                    "Accounting | ERP Systems | Finance Systems | Process Improvement",

                SummaryEnglish = """
                    Accountant with passion for ERP, Finance Systems,
                    digital transformation, and process improvement.
                    I enjoy bridging the gap between finance and technology
                    by improving processes, supporting finance system
                    implementations, and driving automation.
                    """,

                SummarySwedish = """
                    Redovisningsekonom med ett stort intresse för ERP,
                    ekonomisystem, digital transformation och processutveckling.
                    Jag trivs i gränslandet mellan ekonomi och teknik och
                    drivs av att skapa smartare och effektivare arbetssätt.
                    """,

                Location = "Göteborg med omnejd",

                Email = "Ana.M.Ghe@gmail.com",

                LinkedInUrl =
                    "https://www.linkedin.com/in/ana-maria-gheorghe-79764953/",

                OpenToWork = true,

                PreferredWorkMode =
                    "På plats, hybrid eller distans",

                ProfileImageUrl = "images/Ana-Maria.png",
                IntroVideoUrl = null,
            },

            BeyondTheNumbers = new BeyondTheNumbersData
            {
                Text = "Outside of finance and systems, I value curiosity, creativity and continuous learning.",
                IsVisible = true
            },

            Experiences =
            [
                new Experience
                {
                    JobTitle = "Financial Accountant",
                    Company = "GPBM Nordic",
                    Location = "Göteborg",
                    WorkMode = "Hybrid",

                    StartDate = new DateOnly(2026, 3, 1),
                    EndDate = null,
                    IsCurrent = true,

                    Description =
                        "Accounting role with a focus on finance operations, " +
                        "ERP systems, international collaboration and process improvement.",

                    Highlights =
                    [
                        "Accounts payable and accounts receivable",
                        "General ledger accounting",
                        "Bank and account reconciliations",
                        "VAT reporting",
                        "Intercompany transactions",
                        "Month-end closing",
                        "SAP S/4HANA",
                        "International finance process mapping"
                    ],

                    SortOrder = 1
                },

                new Experience
                {
                    JobTitle = "Financial Accountant",
                    Company = "Mentice",
                    Location = "Göteborg",
                    WorkMode = "Hybrid",

                    StartDate = new DateOnly(2023, 4, 1),
                    EndDate = new DateOnly(2025, 9, 1),

                    Description =
                        "Responsible for accounts payable and related balance " +
                        "sheet accounts for Swedish and US entities.",

                    Highlights =
                    [
                        "Accounts payable",
                        "Rillion One implementation",
                        "Multi-currency bank reconciliations",
                        "Foreign exchange adjustments",
                        "Accruals and periodizations",
                        "Month-end and year-end closing",
                        "Financial reporting"
                    ],

                    SortOrder = 2
                },

                new Experience
                {
                    JobTitle = "Ekonomihandläggare / Financial Systems Specialist",
                    Company = "Mölndals stad",
                    Location = "Mölndal",
                    WorkMode = "Hybrid",

                    StartDate = new DateOnly(2018, 12, 1),
                    EndDate = new DateOnly(2023, 4, 1),

                    Description =
                        "Finance systems and support with a focus on accounts " +
                        "payable and later accounts receivable.",

                    Highlights =
                    [
                        "Accounts payable",
                        "Accounts receivable",
                        "Payment processing",
                        "Reminders and debt collection",
                        "Proceedo implementation",
                        "Financial systems support",
                        "Digitalization of invoice processes"
                    ],

                    SortOrder = 3
                },

                new Experience
                {
                    JobTitle = "Ekonomiassistent / Financial Assistant",
                    Company = "Jurek Rekrytering & Bemanning",
                    Location = "Göteborg",

                    StartDate = new DateOnly(2018, 1, 1),
                    EndDate = new DateOnly(2018, 12, 1),

                    Description =
                        "Financial assistant with responsibility for accounts payable.",

                    Highlights =
                    [
                        "End-to-end accounts payable",
                        "Invoice and purchase order reconciliation",
                        "Accounts receivable support",
                        "Cost analysis"
                    ],

                    SortOrder = 4
                },

                new Experience
                {
                    JobTitle = "Ekonomiassistent / Financial Assistant",
                    Company = "Amendo",
                    Location = "Göteborg",

                    StartDate = new DateOnly(2017, 1, 1),
                    EndDate = new DateOnly(2017, 12, 1),

                    Description =
                        "Accounts payable and financial administration.",

                    Highlights =
                    [
                        "Accounts payable",
                        "Purchase order matching",
                        "Account reconciliations",
                        "Customer relations",
                        "Proceedo implementation"
                    ],

                    SortOrder = 5
                }
            ],

            Education =
            [
                new Education
                {
                    School = "Affärshögskolan",
                    Program = "Redovisningsekonom",
                    StartYear = 2014,
                    EndYear = 2016,
                    SortOrder = 1
                },

                new Education
                {
                    School = "Affärshögskolan",
                    Program = "Marknadsinriktad Företagsäljare",
                    StartYear = 2010,
                    EndYear = 2012,
                    SortOrder = 2
                }
            ],

            Skills =
            [
                new Skill
                {
                    Name = "Problemlösning",
                    Category = "Core Skills",
                    SortOrder = 1
                },
                new Skill
                {
                    Name = "Analytisk förmåga",
                    Category = "Core Skills",
                    SortOrder = 2
                },
                new Skill
                {
                    Name = "Kontoavstämning",
                    Category = "Core Skills",
                    SortOrder = 3
                },
                new Skill
                {
                    Name = "Process Improvement",
                    Category = "Core Skills",
                    SortOrder = 4
                },
                new Skill
                {
                    Name = "Digital Transformation",
                    Category = "Core Skills",
                    SortOrder = 5
                },

                new Skill
                {
                    Name = "SAP S/4HANA",
                    Category = "ERP & Financial Systems",
                    SortOrder = 1
                },
                new Skill
                {
                    Name = "Microsoft Dynamics 365 Business Central",
                    Category = "ERP & Financial Systems",
                    SortOrder = 2
                },
                new Skill
                {
                    Name = "IFS",
                    Category = "ERP & Financial Systems",
                    SortOrder = 3
                },
                new Skill
                {
                    Name = "Unit4 ERP (Agresso)",
                    Category = "ERP & Financial Systems",
                    SortOrder = 4
                },
                new Skill
                {
                    Name = "Infor M3 (Movex)",
                    Category = "ERP & Financial Systems",
                    SortOrder = 5
                },
                new Skill
                {
                    Name = "Fortnox",
                    Category = "ERP & Financial Systems",
                    SortOrder = 6
                },

                new Skill
                {
                    Name = "Rillion One",
                    Category = "AP & Invoice Automation",
                    SortOrder = 1
                },
                new Skill
                {
                    Name = "Medius Invoice Workflow",
                    Category = "AP & Invoice Automation",
                    SortOrder = 2
                },
                new Skill
                {
                    Name = "Proceedo",
                    Category = "AP & Invoice Automation",
                    SortOrder = 3
                },
                new Skill
                {
                    Name = "Klippa",
                    Category = "AP & Invoice Automation",
                    SortOrder = 4
                }
            ],

            Languages =
            [
                new Language
                {
                    Name = "Svenska",
                    Proficiency = "Modersmåls- eller tvåspråkig nivå",
                    SortOrder = 1
                },

                new Language
                {
                    Name = "Engelska",
                    Proficiency = "Begränsad yrkeskunskap",
                    SortOrder = 2
                }
            ]
        };
    }
}


    