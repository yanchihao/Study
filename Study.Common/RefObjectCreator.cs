using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study.Common
{
    public class RefObjectCreator : MarshalByRefObject
    {
        static Dictionary<string, string> assembly = new Dictionary<string, string>();
        object sync = new object();

        public T Create<T>()
        {
            Type type = typeof(T);
            if (type.IsInterface)
            {
                if (!assembly.ContainsKey(type.FullName))
                {
                    lock (sync)
                    {
                        if (!assembly.ContainsKey(type.FullName))
                        {
                            string setting = System.Configuration.ConfigurationManager.AppSettings[type.FullName];
                            if (!string.IsNullOrEmpty(setting))
                            {
                                string[] arr = setting.Split(',');
                                assembly.Add(type.FullName, setting);
                                return (T)System.Reflection.Assembly.Load(arr[0]).CreateInstance(arr[1]);
                            }
                            string typeName = type.FullName.Remove(type.FullName.LastIndexOf(type.Name), 1).Remove(type.FullName.LastIndexOf("IService"), 1);
                            string assembleName = type.Assembly.GetName().Name.Remove(type.FullName.LastIndexOf("IService"), 1);
                            assembly.Add(type.FullName, assembleName + "," + typeName);
                            return (T)System.Reflection.Assembly.Load(assembleName).CreateInstance(typeName);
                        }
                    }
                }
                string[] array = assembly[type.FullName].Split(',');
                return (T)System.Reflection.Assembly.Load(array[0]).CreateInstance(array[1]);
            }
            else
                return (T)type.Assembly.CreateInstance(type.FullName);
        }

        public T Create<T>(Type type)
        {
            if (type.IsInterface)
            {
                if (!assembly.ContainsKey(type.FullName))
                {
                    lock (sync)
                    {
                        if (!assembly.ContainsKey(type.FullName))
                        {
                            string setting = System.Configuration.ConfigurationManager.AppSettings[type.FullName];
                            if (!string.IsNullOrEmpty(setting))
                            {
                                string[] arr = setting.Split(',');
                                assembly.Add(type.FullName, setting);
                                return (T)System.Reflection.Assembly.Load(arr[0]).CreateInstance(arr[1]);
                            }
                            string typeName = type.FullName.Remove(type.FullName.LastIndexOf(type.Name), 1);
                            string assembleName = type.Assembly.GetName().Name;
                            assembly.Add(type.FullName, assembleName + "," + typeName);
                            return (T)System.Reflection.Assembly.Load(assembleName).CreateInstance(typeName);
                        }
                    }
                }
                string[] array = assembly[type.FullName].Split(',');
                return (T)System.Reflection.Assembly.Load(array[0]).CreateInstance(array[1]);
            }
            else
                return (T)type.Assembly.CreateInstance(type.FullName);
        }

        public T CreateByFile<T>(string assemblyPath, string classFullName)
        {
            Type type = typeof(T);
            if (type.IsInterface)
            {

                return (T)System.Reflection.Assembly.LoadFile(assemblyPath).CreateInstance(classFullName);
            }
            else
                return (T)type.Assembly.CreateInstance(type.FullName);
        }
    }
}
