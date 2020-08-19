# Remote-Stations-Registration

## Introduction

This project makes possible the remote registration of stations (callable services) with the use of a .NET interface and the UDDI technology. Moreover, security functionality is implemented as: login with hashing and communication encryption (client - station). Furthermore, it is possible to subscribe to stations for receiving notifications when specified changes happen.

## Main Client Interface

This is the main interface that the client uses. It makes possible the look up of all stations in the JUDDI server. In order to access it, it is required to introduce an user and password. This data is saved in a file text where the password is encrypted. It is used as toy example in order to show the functionality of the **password hashing**.

![In a single picture](https://raw.githubusercontent.com/danielallhoff/Remote-Stations-Registration/master/raw_images/client_interface.PNG)

Once the user is logged in, it is required to configure the user´s IP and the port of the **Subscribe Service** (which must be started on the same machine). Then, it is possible to connect to the JUDDI server specifying the address via IP:PORT. When this is done, all the stations that are subscribed to the server will be shown up in the interface. Moreover, each ones data can be shown and modified. As well, all the communication between client and station can be encrypted, with **AESBase 64 Encryption**, in order to hide the information to possible infiltrators.

The interesting functionality in this client is the possibility to receive **notifications** from the stations itself. It is possible to subscribe to a concrete station, specifying which parameter and which are the thresholds values of it in order to emit the notification to the main client. The implementation of this system is not trivial due to the synchronous communication between both components. In order to make it work, a clock has been implemented on a new independent thread which checks continuosly  if a new message has arrived to the Subscribe Service. 

## Station Manager Interface

When starting a new station service, this interface is useful in order to configure the station fast and visually. It permits both registration and visualising the data of the station itself. In order to register the station, it is needed to specify: JUDDI IP and port, the station name and the local IP of the station service. When visualising the data, it is possible to activate or desactivate the encryption of the data. This box has to be checked if the main interface has it also checked in order to make the information between client and station understandable.

![In a single picture](https://raw.githubusercontent.com/danielallhoff/Remote-Stations-Registration/master/raw_images/station_interface.PNG)

## Station Service

The Station Service is a simple service which contains the functionality for accessing and modifying the parameters of the station: temperature, humidity, brightness and text. The three first parameters are simulated ones, which actually should be the live parameters of a real station.

## Subscribe Service

It is the service that is required to load on the client itself. When the client subscribes to a station, the station itself saves the address of the machine and the threshold parameters in a text file. As the thresholds parameters are fired, the station sends a notification directly to the saved IP. All the notifications are saved within the service in a text file which the client can read (and cleaned once showed).



