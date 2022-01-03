using System;
using System.Collections.Generic;
using System.Text;

namespace AliBaba.Repository
{
    interface IRepository<Entity, ID>
    {
        Entity FindById(long id);
        List<Entity> FindByIDs(List<long> ids);
        List<Entity> FindAll();
        Boolean DeleteByID(long id);
        Boolean DeleteByIDs(List<long> ids);
        Entity Save(Entity E);
    }
}
