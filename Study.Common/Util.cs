using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study.Common
{
    public static class Util
    {
        public static T CreateRefObj<T>()
        {
            try
            {
                RefObjectCreator creator = new RefObjectCreator();                
                return creator.Create<T>();
            }
            catch (Exception exc)
            {
                string errorMessage = "T:" + typeof(T).FullName +
                                      "\r\nException:" + exc.ToString();

                throw exc;
            }
        }
    }
}
