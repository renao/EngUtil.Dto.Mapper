﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace engUtil.Dto
{
    public interface IMapper
    {
        Map<TSource, TTarget> CreateMappingFor<TSource, TTarget>()
            where TSource : class
            where TTarget : class;

        Expression<Func<TSource, TTarget>> GetExpressionMap<TSource, TTarget>()
            where TSource : class
            where TTarget : class;

        Expression GetExpressionMap(Type sourceType, Type targetType);

        void GetMapDefinition(object instance);

        TTarget MapTo<TTarget>(object instance);

        IEnumerable<TTarget> MapTo<TTarget>(IEnumerable instance);
    }
}
