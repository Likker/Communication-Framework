#include "Chat.h"
#include "ChatClient.h"

ChatClient c;

enum ChatType
{
	NOTHING,
	CLIENT,
	SERVER
};

class ChatFramework
{
	ChatType type = NOTHING;

	ChatFramework()
	{
		
	}

	~ChatFramework()
	{
	}


	void ConnectAsServer(string port)
	{

	}
	
	void ConnectAsClient(string port, string ip)
	{
		boost::asio::io_service io_service;

		tcp::resolver resolver(io_service);
		tcp::resolver::query query("port", "ip");
		tcp::resolver::iterator iterator = resolver.resolve(query);

		c = new ChatClient(io_service, iterator);

		boost::thread t(boost::bind(&boost::asio::io_service::run, &io_service));
	}

	string GetMessage()
	{
		return "";
	}

	void SendMessage(string message)
	{

	}

};


void main()
{

}