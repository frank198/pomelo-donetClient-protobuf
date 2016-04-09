using System.Collections.Generic;
using Pomelo.DotNetClient;
using SimpleJson;
using UnityEngine;



public class SocketMsgManager 
{
    
    private static PomeloClient pcClient
    {
        get { return PomeloSocket.pc; }
    }

    private static List<Message> JsonList
    {
        get { return PomeloSocket.JsonList; }
    }

   
    static string username
    {
        get { return PomeloSocket.userName; }
    }

    static JsonObject jsonObject
    {
        get
        {
            _jsonObject = new JsonObject();
            _jsonObject.Add("userName", username);
            return _jsonObject;
        }
    }

    static JsonObject jsonObj
    {
        get
        {
            _jsonObject = new JsonObject();
            return _jsonObject;
        }
    }

    private static JsonObject _jsonObject;



    public static void AddListener()
    {
           
            
    }


    ///-------------------------------------------------------------------------------------------------
    /// <summary>  接收消息回调 </summary>
    ///
    /// <remarks>   Administrator, 2015/5/21. </remarks>
    ///
    /// <param name="data"> The data. </param>
    ///-------------------------------------------------------------------------------------------------
    private static void OnActionHandle(Message data)
    {
        lock (JsonList)
        {
            JsonList.Add(data);
        }
    }

        

    public static void RequestEntry()
    {
        _jsonObject = jsonObject;
        _jsonObject.Add("passWord", PomeloSocket.passWord);
        Request("connector.entryHandler.login", _jsonObject);
    }
       

    static void Request(string route, JsonObject msg)
    {
        if (pcClient != null)
        {
            pcClient.request(route, msg, OnActionHandle);
        } 
    }

    static void Request(string route)
    {
        if (pcClient != null)
        {
            pcClient.request(route, OnActionHandle);
        }
    }

    static void Notity(string route, JsonObject msg)
    {
        if (pcClient != null)
        {
            pcClient.notify(route, msg);
        } 
    }
       
}
