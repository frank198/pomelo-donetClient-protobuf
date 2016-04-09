using System.Collections.Generic;
using SimpleJson;
using Pomelo.DotNetClient;


    public class PomeloSocket 
    {

        public static  List<Message> JsonList = new List<Message>();

        public static PomeloClient pc = null;
       
        public static bool IsReConnect = false;
        public static string userName = "admin";
        public static string passWord = "admin";
        private int _port = 0;
       
        void OnApplicationQuit()
        {
            if (pc != null)
            {
                pc.disconnect();
            }
        }
        /// <summary>
        /// 发送登录消息给服务器
        /// </summary>
        /// <param name="host">要连接的服务器host 地址（IP）</param>
        /// <param name="port">要连接的服务器端口</param>
        /// <param name="userName"></param>
		public void Login(string host,int port)
        {
            pc = new PomeloClient(host, port);
 
            pc.connect(null, (data) =>
            {
                 JsonObject msg = new JsonObject();
                 JsonObject login = new JsonObject();
                 login.Add("userName", userName);
                 login.Add("passWord", passWord);
				  msg.Add("login", login);  

				/**  ClientProtos.RequestConnector login = new ClientProtos.RequestConnector();
                login.login = new ClientProtos.Login();
                login.login.userName = userName;
                login.login.passWord = passWord;**/
				pc.request("gate.gateHandler.getConnector", msg, OnQuery);
                
            });
        }

        /// <summary>
        ///  得到服务器返回的IP 和 Port
        /// </summary>
        /// <param name="result"></param>
        void OnQuery(Message result)
        {
           // JsonList.Add(result);
            ServerProtos.SendConnector send = ProtoBuf.Serializer.Deserialize<ServerProtos.SendConnector>(result.stream);
	
        	ConnectGameServer("192.168.1.107",3010);
        }


        public void ConnectGameServer(string host, int port)
        {
           // pc.disconnect();
            if (pc != null)
                pc.disconnect();
            pc = new PomeloClient(host, port);
            _port = port;
            pc.OnDisconnect += OnOnDisconnect;
            pc.connect(null, (data) =>
            {

                SocketMsgManager.AddListener();
                SocketMsgManager.RequestEntry();
                
            });
        }

        private void OnOnDisconnect()
        {
            pc = null;
            if (_port > 0)
            {
                IsReConnect = true;
              //  ConnectGameServer(_port);
            }
           
        }
    }

