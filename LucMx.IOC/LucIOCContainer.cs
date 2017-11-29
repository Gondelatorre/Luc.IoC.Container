using System;
using System.Collections.Generic;

namespace LucMx.IOC
{
    public class LucIocContainer
    {
        public static LucIocContainer GetNewContainer()
        {
            return new LucIocContainer();
        }


        private Dictionary<Type, Type> _config;


        public LucIocContainer()
        {
            _config =new Dictionary<Type, Type>();
        }

        public void Register<T1,T2>()
        {
            _config.Add(typeof(T1),typeof(T2));
        }

        public  T Resolve<T>()
        {
            try
            {
                var res = (T)CCreateInstante(typeof(T), new List<Type>());
                return res;
            }
            catch (Exception ex)
            {
                throw new Exception(string.Format("Ocurrio un problema al resolver la instancia: {0}", ex.Message) );
            }
            
        }

        #region private methods
        private  object CCreateInstante(Type cType, List<Type> avoidListType)
        {
            var tipo = GetType(cType);

            var constructor = tipo.GetConstructors()[0];
            var parameters = constructor.GetParameters();

            List<object> args = new List<object>();
            foreach (var parameter in parameters)
            {
                Type p = parameter.ParameterType;

                ValidateTypeNotInAvoidTypes(p, avoidListType);

                object obj = CCreateInstante(p, GetNewAvoidListTypes(avoidListType, p));
                args.Add(obj);
            }

            return Activator.CreateInstance(tipo, args.ToArray());
        }

        private Type GetType(Type cType)
        {
            if (_config.ContainsKey(cType))
                return _config[cType];
            else
                throw new Exception(string.Format("El tipo {0} no esta registrado.", cType));
        }

        private  List<Type> GetNewAvoidListTypes(List<Type> avoidListTypes, Type newType)
        {
            List<Type> avoidTypes = new List<Type>();
            avoidTypes.Add(newType);
            avoidTypes.AddRange(avoidListTypes);
            return avoidTypes;
        }


        private  void ValidateTypeNotInAvoidTypes(Type t, List<Type> avoidTypes)
        {
            if (avoidTypes.Contains(t))
            {
                throw new Exception("Problema de referencia ciclica");
            }
        }
        #endregion
    }
}
