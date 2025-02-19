using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace FileworxNewsBusiness
{
    internal static class BaseServices
    {
        public static void Add(FileWorxEntity _entity)
        {
            try
            {
                FileHandler.JsonSerialization(_entity);
                
            }
            catch (Exception ex)
            {

                return;
            }
        }
        public static void Update(FileWorxEntity _newEntity)
        {
            try
            {
                FileHandler.UpdateObject(_newEntity);
            }
            catch (Exception ex)
            {
                return ;
            }
        }
        public static void Delete(FileWorxEntity _entity)
        {
            try
            {
                FileHandler.DeleteObject(_entity);
            }
            catch (Exception ex)
            {
                return;
            }
        }
        public static FileWorxEntity Retrieve(FileWorxEntity _obj)
        {

            return FileHandler.JsonDeserializationObject(_obj);
        }
        public static List<FileWorxEntity> RetrieveObjects(FileWorxEntity _obj)
        {
            return FileHandler.JsonDeserializationObjects(_obj);
        }
    }
}
