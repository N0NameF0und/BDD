using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;

namespace SpecFlowJuegoMinas.Steps
{
    [Binding]
    public class GanarSteps
    {
        IWebDriver webDriver = new ChromeDriver(@"C:\Selenium\");
        [Given(@"que escogo los cuadros alazar")]
        public void DadoQueEscogoLosCuadrosAlazar()
        {
            webDriver.Url = "https://localhost:5001/Juego";
            webDriver.Navigate();
        }
        
        [When(@"no selecciono ninguna mina")]
        public void CuandoNoSeleccionoNingunaMina()
        {
            return;
        }
        
        [Then(@"gano el juego con mayor puntaje")]
        public void EntoncesGanoElJuegoConMayorPuntaje()
        {
            return;
        }
    }
}
