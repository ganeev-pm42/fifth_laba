using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsTemplate
{
    public interface IController // связывает представление и модель
    {
        void CalculatePrice();
        void Undo();
    }
    public interface IModel
    {
        void Attach(IObserver observer); // Наблюдаемый объект должен хранить информацию о своих наблюдателях
        void Push(Flight flight);
        void Pop();
    }

    public interface IView
    {
        void SetController(IController controller);
        bool IsValid();
        Flight GetFlight();
    }
    public interface IObserver
    {
        void UpdatePrice(IModel model, ModelEventArgs e);
        void UpdateForm(IModel model, ModelEventArgs e);
    }

}
