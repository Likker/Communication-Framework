// Chat part of the Framework

#include <string>

using namespace std;


class ChatFramework
{
public:

	void ConnectAsServer(string port);
	void ConnectAsClient(string port, string ip);
	void Disconnect();

	string GetIp();

	void SendMessage(string message);
	string GetMessage();
};