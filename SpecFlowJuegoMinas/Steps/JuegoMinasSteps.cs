using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using System;
using TechTalk.SpecFlow;

namespace SpecFlowJuegoMinas.Steps
{
    [Binding]
    public class JuegoMinasSteps
    {
        IWebDriver webDriver = new FirefoxDriver();

        [Given(@"que me registro en el sistema")]
        public void DadoQueMeRegistroEnElSistema()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"ingreso mi nombre")]
        public void CuandoIngresoMiNombre()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"el juego inicializara")]
        public void EntoncesElJuegoInicializara()
        {
            ScenarioContext.Current.Pending();
        }
    }
}
