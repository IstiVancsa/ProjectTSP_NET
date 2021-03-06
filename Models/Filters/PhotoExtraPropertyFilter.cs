﻿using Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Utils;

namespace Models.Filters
{
    public class PhotoExtraPropertyFilter : IBaseFilter<PhotoExtraProperty>
    {
        public int? Id { get; set; }

        public Expression<Func<PhotoExtraProperty, bool>> GetFilter()
        {
            Expression<Func<PhotoExtraProperty, bool>> filter = x => true;

            if (Id.HasValue)
                filter = filter.And(x => x.Id == Id);

            return filter;
        }
    }
}
