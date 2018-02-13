This is the API project to expose Tail API as Web-API.
This project provides the implementation of SignalR to use Tail.cs. Please see the class 'TailHub.cs' for the full implementation.

Also check 
Startup.cs -> app.MapSignalR();

NOTE: Be sure to provide a proper file path in class 'TailHub.cs' to tail the file.

Corresponding Client App i.e. Angular App is located 'Client-App' folder from the root of project directory.
Following are the ts file which implements majority of logics:
	app.module.ts
	app.component.ts