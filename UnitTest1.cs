namespace Joe_s_Pizza;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

public class Tests
{
    [TestFixture]
    IWebDriver driver;
   

    [OneTimeSetUp]
    public void Setup()
    {
        driver = new ChromeDriver();
    }

    [Test]
    public void Test1()
    {
        driver.Url = "E:\\Joe's Pizza\\index.html";
        IWebElement txtAge = driver.FindElement(By.Id("txtAge"));
        IWebDriver validations = driver.FindElement(By.Id("validations"));

        txtAge.SendKeys("4");
        txtAge.SendKeys("\t");
        string validationText = validations.getAttribute("innerHTML");
        if(validationText == "")
        {
            Assert.Pass();
        }
        else
        {
            Assert.Fail();
        }
    }

    [OneTimeTearDown]
    public void Close()
    {

    }
}