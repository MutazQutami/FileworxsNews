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
        public static bool Add(FileWorxEntity _entity)
        {
            try
            {
                FileHandler.JsonSerialization(_entity);
                return true;
            }
            catch (Exception ex)
            {

                return false;
            }
        }
        public static bool Update(FileWorxEntity _newEntity)
        {
            try
            {
                FileHandler.UpdateObject(_newEntity);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public static bool Delete(FileWorxEntity _entity)
        {
            try
            {

                FileHandler.DeleteObject(_entity);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public static FileWorxEntity Retrieve(FileWorxEntity _obj)
        {

            return FileHandler.JsonDeserializationObject(_obj);
        }
        public static List<FileWorxEntity> RetriveObjects(FileWorxEntity _obj)
        {
            return FileHandler.JsonDeserializationObjects(_obj);
        }
    }
}
