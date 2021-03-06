﻿using SG.BannerModule.ViewModels;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace SG.Test
{
    
    
    /// <summary>
    ///This is a test class for IBannerViewModelKTConfigTests and is intended
    ///to contain all IBannerViewModelKTConfigTests Unit Tests
    ///</summary>
    [TestClass()]
    public class IBannerViewModelKTConfigTests
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


internal virtual IBannerViewModel CreateIBannerViewModel()
{
    // TODO: Instantiate an appropriate concrete class.
    IBannerViewModel target = null;
    return target;
}

/// <summary>
///A test for BannerImageUri
///</summary>
[TestMethod()]
public void BannerImageUriGetConfigElementFromKT_ConfigFile_ReturnsTrue()
{
IBannerViewModel target = CreateIBannerViewModel(); // TODO: Initialize to an appropriate value
Uri expected = null; // TODO: Initialize to an appropriate value
    Uri actual;
    target.BannerImageUri = expected;
    actual = target.BannerImageUri;
    Assert.AreEqual(expected, actual);
    Assert.Inconclusive("Verify the correctness of this test method.");
}
    }
}
