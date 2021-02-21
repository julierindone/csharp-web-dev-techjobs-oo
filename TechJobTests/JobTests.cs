using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TechJobsOO;

namespace TechJobsTests
{
    [TestClass]
    public class JobTests
    {
        [TestMethod]
        public void TestSettingJobId()
        {
            Job test_job1 = new Job();
            Job test_job2 = new Job();

            Assert.IsTrue(test_job1.Id == test_job2.Id + 1 || test_job1.Id == test_job2.Id - 1);
        }

        [TestMethod]
        public void TestJobConstructorSetsAllFields()
        {
            Job test_job3 = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality Control"), new CoreCompetency("Persistence"));


            Assert.IsTrue(test_job3.Name == "Product tester");

            Assert.IsTrue(test_job3.EmployerName.Value == "ACME");
            Assert.IsTrue(test_job3.EmployerLocation.Value == "Desert");
            Assert.IsTrue(test_job3.JobType.Value == "Quality Control");
            Assert.IsTrue(test_job3.JobCoreCompetency.Value == "Persistence");
        }

        [TestMethod]
        public void TestJobsForEquality()
        {
            Job test_job4 = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality Control"), new CoreCompetency("Persistence"));
            Job test_job5 = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality Control"), new CoreCompetency("Persistence"));

            Assert.IsFalse(test_job4.Id.Equals(test_job5.Id));
        }

        [TestMethod]
        public void TestToString1()
        {
            Job test_job5 = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality Control"), new CoreCompetency("Persistence"));

            {
                Assert.AreEqual(true, test_job5.ToString().EndsWith("\n"));
                Assert.AreEqual(true, test_job5.ToString().StartsWith("\n"));
            }
            //When passed a Job object, it should return a string that contains a blank line before and after the job information.
        }

        [TestMethod]
        public void TestToString2()
        {
            Job test_job5 = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality Control"), new CoreCompetency("Persistence"));

            Job test_job6 = new Job("Product tester", new Employer(""), new Location(""), new PositionType(""), new CoreCompetency(""));

            string testString5 = $"\nID: {test_job5.Id}\nName: Product tester\nEmployer: ACME\nLocation: Desert\nPosition Type: Quality Control\nCore Competency: Persistence\n";

            string testString6 = $"\nID: {test_job6.Id}\nName: Product tester\nEmployer: Data not available\nLocation: Data not available\nPosition Type: Data not available\nCore Competency: Data not available\n";

            string testToString5 = test_job5.ToString();
            {
                Assert.AreEqual(testString5, testToString5);
            }

            string testToString6 = test_job6.ToString();
            {
                Assert.AreEqual(testString6, testToString6);
            }
        }
    }
}
