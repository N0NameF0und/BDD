using System;
using TechTalk.SpecFlow;

namespace SpecFlowJuegoMinas.Steps
{
    [Binding]
    public class PerderSteps
    {
        [Given(@"que escojo cuadros alazar")]
        public void DadoQueEscojoCuadrosAlazar()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"selecciono alguna mina")]
        public void CuandoSeleccionoAlgunaMina()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"Pierdo el juego con puntaje obtenido")]
        public void EntoncesPierdoElJuegoConPuntajeObtenido()
        {
            ScenarioContext.Current.Pending();
        }
    }
}
