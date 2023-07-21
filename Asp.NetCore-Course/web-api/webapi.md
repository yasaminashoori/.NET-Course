1. What is Backend?

- Every app on the web has two parts: front and back. the front is based on SPA that supported by famous frameworks like Vue, Angular, React. but 
in the past there were based on or SSA(Asp .NET MVC, Laravel, PHP, Node.js, wordpress) it used to supporte both backend and frontend side, for every request from the server front will be made too.

- the front and back of the site connect to each other with API (between Backend and Frontend). So Web API is made without duplicating the Business Logic, and various clients connect to the server. Web API help us that just once we set security settings and other Database operations: Desktop, mobile, and web apps can request their resources with this API.

2. Web API is not a tool but a concept! that works with HTTP Protocol. And when we say API, another concept comes too: Rest (Representational Estate Transfer) and known as RestFul API (Every kan has it's own rest api).

3. When we talked about API another concept comes along named: REST that the apps will be RESTFUL.
RestFul Rules:
1. URL Structure
2. Separation between client and server. (Independent for kind of language)
3. Stateless(client state, or server no need to know the state such as login, logout and etc.)
4. HTTP Verb (POST, PUT, GET, PATCH, DELETE)

4. What is HTTP Request? 
Hyper Text Transfer Protocol is a protocol that sends us from client to server and connects these together. 
1. From Client to Server => Request 
- URL(link address)
- HTTP Method(verb)
- Header(one or many)
- Body(the informations like type of http put, get and etc should be written in this part)
- Data 

2. From Server to Client => Response
- Status Code
- Response Header (one or many)
- Data

- web API works based on this protocol: HTTP Verb
GET: Just read sth from DB and send it to the client.
POST: Create an item in Db or Write it (didn't exist before).
PUT: Update the Data of item.
PATCH: Update just a part of the data (partial data).
DELETE: delete an item in DB.

- Request:
Header: not the primary data and main request. generic ones, like IP and location.
Body: the request should contain data such as the book's info we want to update.
Data: Other info except for Body, such as images etc.

# HTTP Response:

Status code: 5 Category: 1xx, 2xx, 3xx, 4xx, 5xx.

1xx: informational response.

2xx: successful

3xx: Redirection

4xx: Client Error

5xx: Server Error

--------------------------
200: ok

201: created- create the object in the server ( POST)

204: no content - usually, ok but nothing returns

301: Moved permanently 

302: moved temporarily

400: Bad request - client body error. the request has a problem.

401: Unauthorized token or not working (no access).

403: Forbidden - valid token or you don't have access in this level (location not allowed).

404: not found: in the server so the client understands or a route has a problem and is not found.

405: Method  not Allowed - when a method verb is wrong it should be POST but You send Get.

500: all errors in our server, and internal server errors. unhandled exception, or crashed! or bug (dangerous).

503: Service unavailable(Update or etc for google). service didn't work and called: server downs!

504: getaway time out, the process takes so much long related to the server.

5. What do we need? 

- IDE (vs code, visual studio, rider)

- .NET

- Postman

- Database: PostgreSQL and a client to connect with databse (RDBMS) in this case called PGADMMIN (for postgresql and Datagrip for postgre too) that is a GUI to connect with Databse.

6. First project 
we can build the project with this command: dotnet new webapi -f netcoreapp3.1

Contents:
- bin and obj folders used for compile, build and running the project. when you build it you gather the link files in obj and make dll (exe) final file in the bin folder. and the project comes up with these dlls. 

- Controllers folder: 
actions and the weather sample project.

- cs proj
there is where we installed the libraries and nuget packages (nuget is equal for npm in Javascript) and we call the all of the packages in .NET nuget package (kind of package manager) and it will be shown in the cs proj and it's like package json in js projects.

- Program.cs
this is the runner file of the project, main file of program and runs the host. uses from startup file (where you add the configs)

- Weatherforcast.cs that contents the classes.

- NOTE: the main file that starts the project is Controller folder and WeatherForcastController file.

- How to run the project: with dotnet restore we will install the packages  and the dotnet build tha starts the build and compiling to find the possible errors (restore automatic made dll file) and dotnet run for running the program (it get build automatically).

- When you open the host you see 404 error it happens cause there is nothing in the root of our project and the controllers are in the weatherforcast file so we add /weatherforcast at the end of the url.

7. Swagger: there is an standard called "Open API Specification" that doesn't restrict to the language and almost all of them work base on it. means "Language-agnostic programming". for ducomenting, using postman and where do you want to have a client taht undrestands your API dynamically and what methods you have: POST, GET and when you write your API in this standard the Open API finds out and writing the docs for everyone. and one of the clients that is based on Open API and designes a client GUI for us is "Swagger". and write from your API a SDK in every language, specifies the route, request and etc. so both requesting and documenting handles and front wil use it.

- Why we use it? you saw before we have a get method weatherforcast that generates summary randomly but we didn't find out the route of the project and we had to open it by /weatherforcast in the browser or postman.

- How use it> in the .NET we have Nuget package manager and inside of it we have swashbuckle that enables us to access swagger in the .NET projects. with this command add it to our project in vs code: dotnet add package Swashbuckle.AspNetCore
If you look in the cs proj file you will see swashbuckle add to your project in itemgroup.
go to the startup file: rwo main parts configuration (add services) and configureservices (add application, middlewares). and add /swagger to access it.

8. Contents of project: 
- properties: there is a file named launchSettings.json that json is a key-values of objects.
we have a setting for launching the project it means what profiles we should read from to launch.
1. IIS Express: the former .NET web server that only worked on windows. (for .NET Framework).
2. when .NET Core introduced it was suggest a new web server named: Kestrel that was lightweight, cross-platform.
But after all what is web server? when a http request from outside sends to our application, the first where that it hits is the app's web server that in .NET Core by default is Kestrel will be processed and convert to HTTPCONTEXT and sends it to app. but in the production enviroment we should put front of web server a reverse proxy server too, it is a shelter to get the requests at first and then send it to kestrel the famous ones are IIS, Apache, Nginx (even time options to prevent from downing the server or DDOS).

- Environment variables: the variables that sets at the top of your app and can be used all over the app. usage is for saving the configs and settings as environment variables and famous one is "ASPNETCORE ENVIRONMENT".
What is the environment: 1.Development(local IP, host the app in locaal systetm) 2.Staging(before step 3, test the app on the server rfor fixing the bugs in the same as envronment as production, load tst, stress test) 3.Production(end user).

- Swagger used in development step.

- iisSetting used for iis profile.

- appsetting.json and appsettings.development.json: the number two is settigns of run time when run the app till app is opens. these settings aren't for launch time but run time. we have different log levels  

# Intro to Databasse and PostgreSQL


