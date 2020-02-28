using System;
using System.Collections.Generic;
using System.Text;

namespace Customer.Util
{
    public class CustomerDelegates
    {
        //public delegate TResult Func<in T, out TResult>(T arg) where T : IEnumerable<string>, IEnumerable<int> where TResult : IEnumerable<CustomerModel.CustomerModel>;

        public delegate TResult Func<in T1,in T2, out TResult>(T1 arg1, T2 arg2);

        public T3 DoWork<T1,T2,T3>(T1 a, T2 b, Func<T1, T2, T3> container)
        {
            return container(a,b);
        }

    }
}
