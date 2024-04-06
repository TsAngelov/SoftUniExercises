using System;
using NUnit.Framework;
using System.Linq;
using System.Collections.Generic;

namespace SocialMediaManager.Tests
{
    public class InfluencerRepositoryTests
    {
        private InfluencerRepository repository;
        private Influencer influencer;
        private string InfluencerName = "Patrona";
        private int InfluencerFollowers = 1_000_000;
        [SetUp]
        public void Setup()
        {
            repository = new InfluencerRepository();
            influencer = new Influencer(InfluencerName, InfluencerFollowers);
        }

        [Test]
        public void RegisterInfluencer_HappyPath_Test()
        {
            string result = repository.RegisterInfluencer(influencer);

            Assert.AreEqual($"Successfully added influencer {influencer.Username} with {influencer.Followers}", result);
            Assert.AreEqual(1, repository.Influencers.Count());
        }
        [Test]
        public void RegisterInfluencer_WhenNull_ShouldThrowError()
        {
            Assert.Throws<ArgumentNullException>(() => repository.RegisterInfluencer(null));
        }
        [Test]
        public void RegisterInfluencer_WhenAlreadyRegistered_ShouldThrowError()
        {
            repository.RegisterInfluencer(influencer);
            Assert.Throws<InvalidOperationException>(() => repository.RegisterInfluencer(influencer));
        }
        [Test]
        public void RemoveInfluencer_HappyPath_Test()
        {
            repository.RegisterInfluencer(influencer);

            bool result = repository.RemoveInfluencer(InfluencerName);

            Assert.IsTrue(result);
            Assert.AreEqual(0, repository.Influencers.Count());
        }
        [Test]
        [TestCase(null)]
        [TestCase(" ")]
        public void RemoveInfluencer_WhenUsernameIsNullOrWhiteSpace_ShouldThrowError(string username)
        {
            repository.RegisterInfluencer(influencer);
            Assert.Throws<ArgumentNullException>(() => repository.RemoveInfluencer(username));
        }
        [Test]
        public void GetInfluencerWithMostFollowers_HappyPath_Test()
        {
            repository.RegisterInfluencer(influencer);
            repository.RegisterInfluencer(new Influencer("Petar", 100));

            Assert.AreEqual(influencer, repository.GetInfluencerWithMostFollowers());
        }
        [Test]
        public void GetInfluencer_HappyPath_Test()
        {
            repository.RegisterInfluencer(influencer);
            Assert.AreEqual(influencer, repository.GetInfluencer(InfluencerName));
        }
        [Test]
        public void GetInfluencer_WhenUsernameNotFound_ShouldReturnNull()
        {
            var result = repository.GetInfluencer("nqmatakuv");
            Assert.AreEqual(null, repository.GetInfluencer(InfluencerName));
        }
    }
}