using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfService
{
    // ПРИМЕЧАНИЕ. Команду "Переименовать" в меню "Рефакторинг" можно использовать для одновременного изменения имени класса "ServiceGoods" в коде, SVC-файле и файле конфигурации.
    // ПРИМЕЧАНИЕ. Чтобы запустить клиент проверки WCF для тестирования службы, выберите элементы ServiceGoods.svc или ServiceGoods.svc.cs в обозревателе решений и начните отладку.
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.Single)]
    public class ServiceGoods : IServiceRepository<Goods>
    {
        private List<Goods> lst;
        private int id;
        public ServiceGoods()
        {
            this.lst = new List<Goods>();
            id = 1;
        }

        public IEnumerable<Goods> GetAll()
        {
            return lst;
        }

        public Goods Get(int id)
        {
            return lst.Find(m => m.ID == id);
        }

        public void Create(Goods goods)
        {
            goods.ID = id;
            lst.Add(goods);
            id++;
        }

        public void Update(Goods goods)
        {
            var tmp = lst.FirstOrDefault(m => m.ID == goods.ID);
            if(tmp!=null)
            {
                tmp.Name = goods.Name;
                tmp.Description = goods.Description;
                tmp.Price = goods.Price;
            }
        }

        public IEnumerable<Goods> Find(Func<Goods, Boolean> predicate)
        {
            return lst.Where(predicate).ToList();
        }

        public void Delete(int id)
        {
            Goods book = lst.Find(m => m.ID == id);
            if (book != null)
                lst.Remove(book);
        }

        /*public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }

        public Goods GetDataUsingDataContract(Goods composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }*/
    }
}
