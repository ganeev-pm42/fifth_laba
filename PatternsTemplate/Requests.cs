using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsTemplate
{
    public class Requests: IModel // модель - список вопросов
    {
        private List<Flight> listFlight = new List<Flight>(); // список запросов введенных пользователем
        public event ModelHandler<Requests> PriceChanged;
        public event ModelHandler<Requests> Undo;

        public void Attach(IObserver observer)
        {
            PriceChanged += new ModelHandler<Requests>(observer.UpdatePrice);
            Undo += new ModelHandler<Requests>(observer.UpdateForm);
        }

        public void Push(Flight flight)
        {
            listFlight.Add(flight);
            PriceChanged(this, new ModelEventArgs(flight));
        }
        public void Pop()
        {
            if (listFlight.Any())
            {
                Flight temp = listFlight.Last();
                listFlight.Remove(temp);
            }
            Undo.Invoke(this, new ModelEventArgs(listFlight.LastOrDefault()));
        }
                                            
    }
}
