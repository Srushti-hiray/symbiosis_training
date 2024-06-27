using System;
using System.Net; 
class GFG{ 
	static void Main(string[] args) 
{ 
	string hostName = Dns.GetHostName(); 
	Console.WriteLine(hostName); 
	
	string IP = Dns.GetHostByName(hostName).AddressList[0].ToString(); 
	Console.WriteLine("IP Address is : " + IP); 
} 
}
