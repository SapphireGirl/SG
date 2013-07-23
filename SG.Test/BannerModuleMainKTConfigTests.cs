using SG.BannerModule;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Microsoft.Practices.Unity;
using Microsoft.Practices.Prism.Regions;

namespace SG.Test
{
    
    
    /// <summary>
    ///This is a test class for BannerModuleMainKTConfigTests and is intended
    ///to contain all BannerModuleMainKTConfigTests Unit Tests
    ///</summary>
    [TestClass()]
    public class BannerModuleMainKTConfigTests
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
///A test for BannerModuleMain Constructor
///</summary>
[TestMethod()]
public void BannerModuleMainConstructorGetConfigElementFromKT_ConfigFile_ReturnsTrue()
{
IUnityContainer container = null; // TODO: Initialize to an appropriate value
IRegionManager regionManager = null; // TODO: Initialize to an appropriate value
    BannerModuleMain target = new BannerModuleMain(container, regionManager);
    Assert.Inconclusive("TODO: Implement code to verify target");
}

/// <summary>
///A test for RegisterTypes
///</summary>
[TestMethod()]
[DeploymentItem("SG.BannerModule.dll")]
public void RegisterTypesGetConfigElementFromKT_ConfigFile_ReturnsTrue()
{
PrivateObject param0 = null; // TODO: Initialize to an appropriate value
BannerModuleMain_Accessor target = new BannerModuleMain_Accessor(param0); // TODO: Initialize to an appropriate value
    target.RegisterTypes();
    Assert.Inconclusive("A method that does not return a value cannot be verified.");
}

/// <summary>
///A test for RegisterViewsWithRegionAndResolveVM
///</summary>
[TestMethod()]
[DeploymentItem("SG.BannerModule.dll")]
public void RegisterViewsWithRegionAndResolveVMGetConfigElementFromKT_ConfigFile_ReturnsTrue()
{
PrivateObject param0 = null; // TODO: Initialize to an appropriate value
BannerModuleMain_Accessor target = new BannerModuleMain_Accessor(param0); // TODO: Initialize to an appropriate value
    target.RegisterViewsWithRegionAndResolveVM();
    Assert.Inconclusive("A method that does not return a value cannot be verified.");
}

/// <summary>
///A test for ErrorCode
///</summary>
[TestMethod()]
public void ErrorCodeGetConfigElementFromKT_ConfigFile_ReturnsTrue()
{
IUnityContainer container = null; // TODO: Initialize to an appropriate value
IRegionManager regionManager = null; // TODO: Initialize to an appropriate value
BannerModuleMain target = new BannerModuleMain(container, regionManager); // TODO: Initialize to an appropriate value
int expected = 0; // TODO: Initialize to an appropriate value
    int actual;
    target.ErrorCode = expected;
    actual = target.ErrorCode;
    Assert.AreEqual(expected, actual);
    Assert.Inconclusive("Verify the correctness of this test method.");
}
    }
}
