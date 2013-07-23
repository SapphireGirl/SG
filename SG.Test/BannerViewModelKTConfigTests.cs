﻿using SG.BannerModule.ViewModels;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using SG.BannerModule.Views;
using Microsoft.Practices.Unity;

namespace SG.Test
{
    
    
    /// <summary>
    ///This is a test class for BannerViewModelKTConfigTests and is intended
    ///to contain all BannerViewModelKTConfigTests Unit Tests
    ///</summary>
    [TestClass()]
    public class BannerViewModelKTConfigTests
    {


        private TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Additional test attributes
        // 
        //You can use the following additional attributes as you write your tests:
        //
        //Use ClassInitialize to run code before running the first test in the class
        //[ClassInitialize()]
        //public static void MyClassInitialize(TestContext testContext)
        //{
        //}
        //
        //Use ClassCleanup to run code after all tests in a class have run
        //[ClassCleanup()]
        //public static void MyClassCleanup()
        //{
        //}
        //
        //Use TestInitialize to run code before running each test
        //[TestInitialize()]
        //public void MyTestInitialize()
        //{
        //}
        //
        //Use TestCleanup to run code after each test has run
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{
        //}
        //
        #endregion


/// <summary>
///A test for BannerViewModel Constructor
///</summary>
[TestMethod()]
public void BannerViewModelConstructorGetConfigElementFromKT_ConfigFile_ReturnsTrue()
{
IBannerView bannerView = null; // TODO: Initialize to an appropriate value
IUnityContainer container = null; // TODO: Initialize to an appropriate value
    BannerViewModel target = new BannerViewModel(bannerView, container);
    Assert.Inconclusive("TODO: Implement code to verify target");
}

/// <summary>
///A test for BannerImageUri
///</summary>
[TestMethod()]
public void BannerImageUriGetConfigElementFromKT_ConfigFile_ReturnsTrue()
{
IBannerView bannerView = null; // TODO: Initialize to an appropriate value
IUnityContainer container = null; // TODO: Initialize to an appropriate value
BannerViewModel target = new BannerViewModel(bannerView, container); // TODO: Initialize to an appropriate value
Uri expected = null; // TODO: Initialize to an appropriate value
    Uri actual;
    target.BannerImageUri = expected;
    actual = target.BannerImageUri;
    Assert.AreEqual(expected, actual);
    Assert.Inconclusive("Verify the correctness of this test method.");
}
    }
}
