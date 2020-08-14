using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;

namespace SpecFlowJuegoMinas.Steps
{
    [Binding]
    public class PerderSteps
    {
        IWebDriver webDriver = new ChromeDriver(@"C:\Selenium\");
        [Given(@"que escojo cuadros alazar")]
        public void DadoQueEscojoCuadrosAlazar()
        {
            webDriver.Url = "https://localhost:5001/Juego";
            webDriver.Navigate();
        }
        
        [When(@"selecciono alguna mina")]
        public void CuandoSeleccionoAlgunaMina()
        {
            return;
        }
        
        [Then(@"Pierdo el juego con puntaje obtenido")]
        public void EntoncesPierdoElJuegoConPuntajeObtenido()
        {
            return;
        }
    }
}
