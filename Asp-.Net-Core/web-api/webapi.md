- What is Backend?

Every app on the web has two parts front and back. 

the front is based on SPA today or SSA(Asp .NET MVC, Laravel, PHP, Node.js) in the past.

they connect with API. (between Backend and Frontend).

So Web API is made without duplicating the Business Logic, and various clients connect to the server. Web API help us that just once we set security settings and other Database operations Desktop, mobile, and web apps can request their resources with this API.

Web API is not a tool but a concept! that works with HTTP Protocol.

And when we say API, another concept comes too: Rest (Representational Estate Transfer) and known as RestFul API (Every kan has it's own rest api).

RestFul Rules:
1. URL Structure
2. Separation between client and server. (Independent for kind of language)
3. Stateless(client state, or server no need to know)
4. HTTP Verb (POST, PUT, GET, PATCH, DELETE)

What is HTTP Request? 
Hyper Text Transfer Protocol is a protocol that sends us from client to server and connects these together.
From Client to Server => Request ( URL(link address), HTTP Method(verb), Header(one or many), Body, Data )
From Server to Client => Response (Status Code, Response Header, Data)

HTTP Verb: 

GET: Just read sth from DB and send it to the client.

POST: Create an item in Db or Write it (didn't exist).

PUT: Update the Data.

PATCH: Update just a part of the data (partial data).

DELETE: delete an item in DB.

Header: not the primary data. generics like IP, Location

Body: the request should contain data such as the book's info we want to update.

Data: Other info except for Body, such as images etc.


# HTTP Response:

Status code: 5 Category: 1xx, 2xx, 3xx, 4xx, 5xx.

1xx: informational response.

2xx: successful

3xx: Redirection

4xx: Client Error

5xx: Server Error

---------------------------

200: ok

201: created- create the object in the server ( POST )

204: no content - usually, ok but nothing returns

301: Moved permanently 

302: moved temp

400: Bad request - client body error. the request has a problem. 

401: Unauthorized token or not working. (no access)

403: Forbidden - valid token or you don't have access in this level (location not allowed)

404: not found: in the server so the client understands or a route has a problem and is not found

405: Method  not Allowed - when a method verb is wrong it should be POST but You send Get.

500: all errors in our server, and internal server errors. unhandled exception, or crashed! or bug. (dangerous)

503: Service unavailable. don't service

504: getaway time out, the process takes so much long related to the server.
