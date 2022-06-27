# Advanced Front-End Frameworks


**1.** Describe the two ways to bind Data in Vue?
<!-- enter you answer in the space below -->
```
You can bind with v-bind or a colon.
```

**2.** The `SPA` acronym stands for what?
<!-- enter you answer in the space below -->
```
SPA stands for single page application
```
**3.** What are some of the advantages/uses of a `SPA` over a traditional one?
<!-- enter you answer in the space below -->
```
A SPA will have better performance, and could give a better user experience and likely easier to code for as well.
```
**4.** What does the `onMounted` method in Vue do?
<!-- enter you answer in the space below -->
```
Onmounted is where functions can get defined and invoked or computeds can be defined when the page is rendered or "mounted".
```
**5.** What is the `v-model` attribute in Vue for, and when might you use it?
<!-- enter you answer in the space below -->
```
V-model is for populating or receiving data in an HTML input fields. You can populate or extract object/object properties defined with a ref.
```
**6.** The `v:on` (`@`) directive can be used for what?
<!-- enter you answer in the space below -->
```
it is used for listening to events on the page/DOM and executing javascript based on those events. An example being onclick or on form submit.
```
**7.** Which Vue attributes(directives) could you use to conditionally render elements on a page?
<!-- enter you answer in the space below -->
```
You can use v-if or v-on to show or hide something based on a true or false result in javascript.
```
**8.** What is the purpose of the `key` attribute when using `v-for` on an element?
<!-- enter you answer in the space below -->
```
The key attribute is how vue knows what individual item in a collection to update on the DOM. It needs to be a unique property such as an ID on the items of the array you are iterating over. 
```
**9.** What is the `<slot>` element and what is it used for?
<!-- enter you answer in the space below -->
```
You can define a slot in a child component's template and inject HTML into that slot from a parent component. This makes a child component reusable. It is definitely helpful in keeping code clean and understandable.
```