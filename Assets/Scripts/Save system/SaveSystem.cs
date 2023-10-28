using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System;

public static class SaveSystem <T> where T : class
{
    public static void SavePlayer(T Data, string subPath)
    {
        BinaryFormatter formatter = new BinaryFormatter();
        string path = Application.persistentDataPath + subPath;
        if (File.Exists(path))
        {
            File.Delete(path);
        }


        FileStream stream = new FileStream(path, FileMode.Create);
        
        

        formatter.Serialize(stream, Data);
        stream.Flush();
        stream.Close();
        stream.Dispose();
        Debug.Log(path);

        //using (FileStream stream = new FileStream(path, FileMode.Create))
        //{
        //    PlayerData data = new PlayerData(player);
        //    formatter.Serialize(stream, data);
        //}
    }

    public static T LoadPlayer(string subPath)
    {
        string path = Application.persistentDataPath + subPath;
        if (File.Exists(path))
        {
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream stream = new FileStream(path, FileMode.Open, FileAccess.Read);

            stream.Position = 0;

            object readData = formatter.Deserialize(stream);

           T convertedObject = (T)readData;

            stream.Flush();
            stream.Close();
            stream.Dispose();
            return convertedObject;
        }
        else
        {
            Debug.LogError("Save file not found in " + path);
            return default(T);
        }

    }


    private static T ConvertToT (object data)
    {

        if (data is T)
        {
            return (T)data;
        }
        try
        {
            return (T)Convert.ChangeType(data, typeof(T));
        }
        catch (InvalidCastException)
        {
            return default(T);
        }


    }


}
