# Intro to Server side concerns with JavaScript

**1.** What do the letters of the acronym `CRUD` stand for?
<!-- enter you answer in the space below -->
```
  CRUD stands for create, read, update, delete
```
**2.** Each action that `CRUD` represents maps to an HTTP request. What HTTP request does each `CRUD` action correspond to?
<!-- enter you answer in the space below -->
```
    HTTP GET - reads data
    HTTP DELETE - deletes data
    HTTP PUT - edits/replaces data
    HTTP POST - creates data
```
**3.** What does `ORM` stand for? Which `ORM` do we use when interacting with MongoDB
<!-- enter you answer in the space below -->
```
  ORM stands for object relational mappers. We use mongoose libraries for interacting with MongoDB.
```
**4.** Which two `HTTP` request types include a body?
<!-- enter you answer in the space below -->
```
    A Post and PUT will need to contain data in the body of the HTTP request. For our purposes we use raw data in JSON format.
```
**5.** In a/an _______ coding model, when you call a function, it returns only when the action has finished and stops your program for the time the action takes. Likewise in a/an _______ coding model, multiple things are allowed to happen at one time. When you perform an action, your program continues to run.  Fill in the blanks.
<!-- enter you answer in the space below -->
```
In a synchronous / linear. In an asynchronous coding model multiple things are allowed to happen at one time.
```

**6.** Fill in the missing piece of this snippet of code.
```js
import mongoose from "mongoose"
let Schema = mongoose.Schema;
from the model on the server side
```
<!-- enter you answer in the space below -->
```js
import mongoose from "mongoose"
let Schema = mongoose.Schema;
from the model on the server side

```
**7.** What is middleware?
<!-- enter you answer in the space below -->
```
  these are the waiters at the restaurant. When we define out HTTP methods in the controller on the server side, we act on the req, res, next (request, response, next (the next door in the hallway that is our backend)
```
**8.** The ______ pipeline delivers information from the client while the ______ pipeline returns it. Fill in the blanks. 
<!-- enter you answer in the space below -->
```
...? I could not find any references to pipelines client delivery / client send in node.js/mongo/js.
```
**9.** 
Demonstrate the pattern that is used to include a request query with the client's `HTTP` request providing the property `tag` and the value `winter`.
<!-- enter you answer in the space below -->
```
/api/objects?tag=winter
```