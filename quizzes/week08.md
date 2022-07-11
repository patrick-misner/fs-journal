# Deploying Applications

**1.** What is the package.json file used for?
<!-- enter you answer in the space below -->
```
it is a list of libraries / components that are installed. When you run an npm i it will use this list to know what to get.
``` 
**2.** At what level of your project do you need package.json when deploying your application? Why?
<!-- enter you answer in the space below -->
```
At the root direction of your client ( front end ). This is where everything is coded to look for your application's dependencies in package.json
```
**3.** What command will ensure that your Vue code is compiled properly for deployment?
<!-- enter you answer in the space below -->
```
npm run build
```
**4.** _______ are used to provide your application with specific data based on it's environment. For example: connections strings, private keys or port. Fill in the blank.
<!-- enter you answer in the space below -->
```
environment files (.env for server and env.js for front-end)
```
**5.** What are the two ways to view the logs from your Heroku app.
<!-- enter you answer in the space below -->
```
heroku logs -n 1500 and heroku logs --tail
```
**6.** How do you update an app already deployed on Heroku?
<!-- enter you answer in the space below -->
```
do a heroku git:remote -a projectName and then git push heroku master

```
**7.** Why is branching important to version control?
<!-- enter you answer in the space below -->
```
Branching is the cleanest and safest way for a team to write new code and test a new version without any involvement with production/main/master branch..
```
**8.** When should code review happen?
<!-- enter you answer in the space below -->
```
When everything is tested on a branch and you are ready to merge to main/master
```
**9.** What is the term used to define combining two branches?
<!-- enter you answer in the space below -->
```
In the world of git this is called a merge.
```