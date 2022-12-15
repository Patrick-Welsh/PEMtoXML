# PEMtoXML
### Console application to convert an RSA public/private key PEM block to XML

#### Before running this script, please ensure you have a valid RSA key in PKCS1 format.

#### In the case of public keys, you will need to get the PEM block for that key with a command such as the following:
    ssh-keygen -f <file.name> -e -m pem
    
#### For example:    
    ssh-keygen -f rsa.pub -e -m pem

#### For private keys, it will already be in PEM format. 

#### Once you have a key, add it's contents into the following file:
    C:\Users\<Account Name>\source\repos\PEMtoXML\PEMtoXML\bin\Debug\net6.0\rsa.pem

#### Then execute the program. Once it has finished, a file called rsa.xml will have been generated, containing the converted key. 
