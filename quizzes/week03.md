# Application Architecture, MVC Design Pattern

**1.** What are the Pillars of Object Oriented Programming (`OOP`)?
<!-- enter you answer in the space below -->
```
There are three pillars of OOP.

1. Encapsulation - keeping data controlled and encapsulated away from the rest of tghe application.
2. Inheritance - We only have to define a parent class once and not hundreds or more times throughout an application. the front end doesn't need to know exactly how we are depositing money into a balance class.
3. Polymorphism - the ability of objects to take on many forms. An example of this is Creating a child class, like when main.js creates a new child controller class, using the parent class defined in the controller.
```
**2.** How would you access the `name` of the below object using the `property` variable?
```js
let staff = {
  name: "Tim",
  age: 26,
  job: "Code Monkey"
  }
let property = 'name'
```

<!-- enter you answer in the space below -->
```
property = staff.name
console.log(property)
```
**3.** What is Encapsulation?
<!-- enter you answer in the space below -->
```
Encapsulation is what we are using in the appstate, we have objects or arrays defined that are only accessible via the proxyState function. The objects are encapsulated and only accessible and changeable via the object's methods defined.(proxystate)
```
**4.** What does the S stand for in the `SOLID` principles?
<!-- enter you answer in the space below -->
```
S - Single responsibility principle. This is saying that a class should only have one job, such as the CarsController only manipulating Car data in Greg's List.

O - Open closed principle
L - Liskov substitution principle
I - Interface segregation principle
D - dependency inversion principle

```
**5.** What the difference between a `class` and an instance of a `class`?
<!-- enter you answer in the space below -->
```
A class is kind of the definition and organization of a set of functions/objects/data where an instance of the class is created somewhere else to access those functions/objects/data defined in the class from somewhere else, such as the front end.
```
**6.** What is a `Proxy` object?
<!-- enter you answer in the space below -->
```
To me a proxy is kind of like a gateway or tunnel, a good word describing the intention of a proxy in JS. A proxy is a method to manipulate, delete, read or create data to be used by the application. We use the proxystate to access data in a class called the Appstate.
```

**7.** What is the purpose of the `MVC` pattern?
<!-- enter you answer in the space below -->
```
The inteded purpose of the Model/View/Controller is to segregate functions. It serves as a way to keep unneeded or private functions from the front end. Allows multiple contributors to edit at the same time. Organizes and keeps code looking nice and clean. Largely the MVC pattern enables a secure and flexible system to scale up. Without it, having more than 2 contributors to the codebase and a few users would be almost impossible to manage.

```
**8.** What is the job of the `Controller` in the `MVC` Pattern?
<!-- enter you answer in the space below -->
```
The controller is like the handler of data. It is a class with some functions defined for the front end to use to read/manipulate/edit data in a controlled way. It directs those requests to the proper place (service/model). The controller is like the waitress at the restaurant, bringing info and collecting info to bring to the guests(front end).

```

**9.** What is the job of the `Service` in `MVC`?
<!-- enter you answer in the space below -->
```
The service performs business logic, such as totaling up items or inserting or reading an object within the Appstate. It is like the Cooks in the restaurant analogy. Performing the work the controller(waiter) has asked for.
```
**10.** What is the job of the `Model` in `MVC`?
<!-- enter you answer in the space below -->
```
The model is the definition of what the data should look like in the appstate. In the restaurant analogy maybe it could be similar to the head chef /manager, controlling the recipes and products, what gets ordered, where it is stored and the steps needed to change or provide the food/data.

```
