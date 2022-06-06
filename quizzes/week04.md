# UnderStanding Asynchronous Code, and API's

**1.** What is the difference between `asynchronous` code and `synchronous` code?
<!-- enter you answer in the space below -->
```
in JS, asynchronous code can handle varying times to complete. Synchronous code runs line by line until complete.


```
**2.** What is an event listener?
<!-- enter you answer in the space below -->
```
An event listener is like a service that gets notified when the state of an object has been changed in any way.

```
**3.** What does the `O` represent in the `SOLID` principles?
<!-- enter you answer in the space below -->
```
It stands for Open closed principle
```
**4.** What is a callback / higher order function?
<!-- enter you answer in the space below -->
```
A callback is like a function that gets run inside of a function. Defined functions are hoisted too, so a function above could call it.
```
**5.** What is a `promise`? How do you capture an error from a `promise`?
<!-- enter you answer in the space below -->
```
A promise is a response from an endpoint that says I will try to get what you are looking for. You can use a try/catch method to attempt to get the data but render an error on failure.

```
**6.** Name three processes used to make requests over `HTTP`?
<!-- enter you answer in the space below -->
```
There is a Get, Put, Post and Delete.

Get to fetch data
Put to change data
Post to create data
Delete to delete

```
**7.** What does the `API` acronym stand for?
<!-- enter you answer in the space below -->
```

It is a broad acronym meaning Application Programming Interface.

```
**8.** In the `MVC` design pattern, who is responsible for making calls to `APIs`?
<!-- enter you answer in the space below -->
```
The Service is where you should be making calls to the API, with a try/catch on the controller.

```
**9.** What is the purpose of encapsulation in programming?
<!-- enter you answer in the space below -->
```
encapsulation is used for the security, stability, and organization of a web application.
```
**10.** What is `HTTP` response code for a successful request?
<!-- enter you answer in the space below -->
```
200 is the success code for HTTP
```
**11.** What is a 500 error?
<!-- enter you answer in the space below -->
```
500 error is a server side error (internal server error)
```