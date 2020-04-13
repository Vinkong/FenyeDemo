using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FenyeMvcDemo.Models
{
    public class PagerQuery<TPager, TEntityList>
    {
        public PagerQuery(TPager pager, TEntityList entityList)
        {
            this.Pager = pager;
            this.EntityList = entityList;
        }
        public TPager Pager { get; set; }
        public TEntityList EntityList { get; set; }


    }
}