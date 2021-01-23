using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer.Models;

namespace DataLayer.Context
{
    public class UnitOfWork:IDisposable
    {
        MyContext db=new MyContext();

        private MyGenericRepository<Person> personRepository;

        public MyGenericRepository<Person> PersonRepository
        {
            get
            {
                if (personRepository == null)
                {
                    personRepository=new MyGenericRepository<Person>(db);
                }

                return personRepository;
            }
        }


        public void Dispose()
        {
            db.Dispose();
        }
    }
}
