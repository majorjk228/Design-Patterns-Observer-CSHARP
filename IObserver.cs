using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_Observer_CSHARP
{
    // Интерфейс у наблюдателя (получателя)
    public interface IObserver
    {
        void Update(News news); // Метод будет вызываться, когда наш наблюдатель будет получать уведомление (к примеру: о новой новости)
    }
}
