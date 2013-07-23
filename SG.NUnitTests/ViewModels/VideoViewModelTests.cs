using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Practices.Unity;
using NUnit;
using NUnit.Framework;
using Should;
using Should.Core;
using Should.Fluent;
using System.Windows;
using SG.Util;


namespace SG.NUnitTests.ViewModels
{
    [TestFixture]
    public class VideoViewModelTests
    {
        private ISGLogger _logger;
        private IUnityContainer _container;

        public VideoViewModelTests(IUnityContainer container)
        {
             _container = container;
            _logger = _container.Resolve<ISGLogger>();
        }
        [SetUp]
        public void Setup()
        {
           
            _logger.WriteToLog("Setting up VideoViewModelTests");
        }
        

        // Testing the Constructor
        [Test]
        public void GetVideoDisplayName_Returns_Correctly()
        {
            string TempDisplayName = (string)Application.Current.Resources["VideoDisplay"];

            _logger.WriteToLog("TempDisplayName:");
            _logger.WriteToLog(TempDisplayName);
            Assert.Equals(TempDisplayName, "This is our display Name");
        }

        public void CreateVideo_Returns_Instanceof_Video()
        {
            
        }

        // Test the Video Region was correctly instanciated.

        // Test the Video Service
        // Test the VideoService sent back the correct video
        // Create a mock video

        // Test the Play Video

        // Test the Pause Video

        // Test the Stop Video

    }
}
