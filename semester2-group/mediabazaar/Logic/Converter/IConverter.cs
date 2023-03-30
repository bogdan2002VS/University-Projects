using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Converter
{
    public interface IConverter<TSource, TDestination>
    {
        TDestination Convert(TSource source_object);
        TSource Convert(TDestination source_object);

        TDestination[] Convert(List<TSource> source_object);
        TSource[] Convert(List<TDestination> source_object);
    }

}
