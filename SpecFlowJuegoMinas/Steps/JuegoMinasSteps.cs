using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System;
using System.Data.Common;
using TechTalk.SpecFlow;

namespace SpecFlowJuegoMinas.Steps
{
    [Binding]
    public class JuegoMinasSteps
    {
        
        IWebDriver webDriver = new ChromeDriver(@"C:\Selenium\");

        [Given(@"que me registro en el sistema")]
        public void DadoQueMeRegistroEnElSistema()
        {
            webDriver.Url = "https://localhost:5001/Login";
            webDriver.Navigate();

            var input = webDriver.FindElement(By.ClassName("prueba")); 
        }
        
        [When(@"ingreso mi nombre")]
        public void CuandoIngresoMiNombre()
        {
            return;
        }
        
        [Then(@"el juego inicializara")]
        public void EntoncesElJuegoInicializara()
        {
            return;
        }
    }
}
