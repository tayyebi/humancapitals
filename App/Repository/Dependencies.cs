using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Repository
{
    class Dependencies
    {
        public Person person = new Person();
        public Course course = new Course();
        public Transaction transaction = new Transaction();
        public Attending attending = new Attending();
        public Voluntarily voluntarily = new Voluntarily();
    }
}
