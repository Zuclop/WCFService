using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfService
{
    // ПРИМЕЧАНИЕ. Команду "Переименовать" в меню "Рефакторинг" можно использовать для одновременного изменения имени интерфейса "IService1" в коде и файле конфигурации.
    [ServiceContract]
    public interface IServiceRepository<T> where T : class
    {

        [OperationContract]
        IEnumerable<T> GetAll();

        [OperationContract]
        T Get(int id);

        [OperationContract]
        IEnumerable<T> Find(Func<T, Boolean> predicate);

        [OperationContract]
        void Create(T item);

        [OperationContract]
        void Update(T item);

        [OperationContract]
        void Delete(int id);
        // TODO: Добавьте здесь операции служб
    }


    // Используйте контракт данных, как показано в примере ниже, чтобы добавить составные типы к операциям служб.
    [DataContract]
    public class Goods
    {
        int id;
        string name;
        string description;
        double price;

        [DataMember]
        public int ID
        {
            get { return id; }
            set { id = value; }
        }

        [DataMember]
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        [DataMember]
        public string Description
        {
            get { return description; }
            set { description = value; }
        }

        [DataMember]
        public double Price
        {
            get { return price; }
            set { price = value; }
        }
    }
}
