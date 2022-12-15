// See https://aka.ms/new-console-template for more information
using System.Security.Cryptography;
using System.Xml;

var privateKey = await File.ReadAllTextAsync("rsa.pem");
var rsa = RSA.Create();
rsa.ImportFromPem(privateKey.ToCharArray());
var d = new XmlDocument();
d.LoadXml(rsa.ToXmlString(true));
d.Save("rsa.xml");


