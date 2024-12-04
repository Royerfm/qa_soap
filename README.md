# WCF Hello World Project whit SOAP architecture

This is a simple C# project that implements a SOAP service using WCF. The service exposes a `HelloWorld` method that returns a text message.

## Project Structure

- `IService.cs`: Defines the service contract.
- `Service.svc.cs`: Service implementation.
- `HelloWorld.svc`: Service access point.
- `App.config`: WCF configuration.
- `Program.cs`: Client that consumes the service.

## Installation

1. Make sure you have Visual Studio installed with support for C# and WCF applications.
2. Open the project in Visual Studio.
3. Run the project.

## How it works

The `IService` service has a method called `HelloWorld` that returns the text "Hello World from WCF!". The client connects to the service and displays this message in the console.

## Run the Client

1. Start the WCF service.
2. Run the client (`Program.cs`).
3. The client will display the message "Hola Mundo!".
