# Single Page Applications with Vue

**1.** What is the entrypoint of an application?
<!-- enter you answer in the space below -->
```
  It is where end users go to access the application. Such as the baseURL for your website, in our case localhost
```
**2.** What is the difference between a vue `component` and `page`?
<!-- enter you answer in the space below -->
```
  A component is something that can be viewed on a page. A page would contain a template and potentially some components retrieved within that page.
```
**3.** What feature of Vue can be used to repeat an element using a collection of data?
<!-- enter you answer in the space below -->
```
  You can use a V-for="x in collection" on the element you want to repeat.
```
**4.** What are the three tags that make up a Vue component?
<!-- enter you answer in the space below -->
```
  A template, script and style. Template where the HTML goes, script where the vue logic and data export/imports go, and a style for the CSS.
```
**5.** What does the `L` represent in the `SOLID` principles?
<!-- enter you answer in the space below -->
```
  Liskov substitution principle
```
**6.** Which component in Vue does the vue-router use to mount pages onto?
<!-- enter you answer in the space below -->
```
    The routes inside the router.js file. You define what pages will mount based on the route the user has accessed.
```
**7.** What is the difference between the `AppState` and the state object within a component?
<!-- enter you answer in the space below -->
```
    The data in the AppState is global where the state object exists on the component. It is accessed with this.object/array instead of appstate.object/array 
```
**9.** What is the responsibility of `Services` in our Vue projects?
<!-- enter you answer in the space below -->
```
  The services handle all data manipulation and collection for pages and components, whether it's data in the AppState or an API.
```
**10.** Which file contains the root element of your Vue project?
<!-- enter you answer in the space below -->
```
  The App.vue file has the root element "App"
```
**11.** The ______ tag is used to alter the styling of your entire Vue project.  Adding the ______ attribute to this tag will limit it to just the component it exists.  Fill in the blank.
<!-- enter you answer in the space below -->
```
Style, scoped
```
**12.** What is the Vue method used to create watchable objects such as `state` or `AppState`?
<!-- enter you answer in the space below -->
```
 computed(() => AppState.array)
 computed(() => this.array)
```