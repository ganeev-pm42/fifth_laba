using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsTemplate
{
    public class Controller : IController
    {
        IView view;
        IModel model;

        public Controller(IView view, IModel model)
        {
            this.view = view;
            this.model = model;

            this.view.SetController(this);
            if (view is IObserver)
                this.model.Attach((IObserver)view);
        }

        public void CalculatePrice()
        {
            if (view.IsValid()) // если данные корректны
            {
                Flight flight = view.GetFlight(); // создаем объект на основе данных, предоставленных видом view
                flight.Price = CalculationFacade.GetPrice(flight); // вычисляем стоимость запроса
                model.Push(flight);//добавлем объект в модель
            }
        }
        public void Undo()
        {
            model.Pop();
        }
    }
}
