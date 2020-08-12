using System;
using TechTalk.SpecFlow;

namespace SpecFlowJuegoMinas.Steps
{
    [Binding]
    public class GanarSteps
    {
        [Given(@"que escogo los cuadros alazar")]
        public void DadoQueEscogoLosCuadrosAlazar()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"no selecciono ninguna mina")]
        public void CuandoNoSeleccionoNingunaMina()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"gano el juego con mayor puntaje")]
        public void EntoncesGanoElJuegoConMayorPuntaje()
        {
            ScenarioContext.Current.Pending();
        }
    }
}
