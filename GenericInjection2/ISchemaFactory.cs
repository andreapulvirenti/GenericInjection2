using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace GenericInjection2
{
    public interface ISchemaFactory<T, P> where T : class
                                           where P : ISchemaParameter
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="schemaParameter"></param>
        /// <returns></returns>
        T CreateSchema(P schemaParameter);

    }

    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <typeparam name="P"></typeparam>
    public interface ISchemaFactoryAsync<T, P> where T : class
                                            where P : ISchemaParameter
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="schemaParameter"></param>
        /// <returns></returns>
        Task<T> CreateSchemaAsync(P schemaParameter);

    }
}
