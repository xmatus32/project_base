# backend

## Recommended IDE Setup

[VSCode](https://code.visualstudio.com/) + [Volar](https://marketplace.visualstudio.com/items?itemName=Vue.volar) (and disable Vetur) + [TypeScript Vue Plugin (Volar)](https://marketplace.visualstudio.com/items?itemName=Vue.vscode-typescript-vue-plugin).

## Type Support for `.vue` Imports in TS

TypeScript cannot handle type information for `.vue` imports by default, so we replace the `tsc` CLI with `vue-tsc` for type checking. In editors, we need [TypeScript Vue Plugin (Volar)](https://marketplace.visualstudio.com/items?itemName=Vue.vscode-typescript-vue-plugin) to make the TypeScript language service aware of `.vue` types.


## Dev Project Setup
To launch local instance of c# microservice navigate to the `microservices/{microservice}` folder. Run this command to build the project
```sh
dotnet build
``` 

Run
```sh
dotnet run
``` 
to launch local instance.

## Generate microservice
To generate new c# microservice u need to run this command: 
```sh
dotnet new webapi –name NewMicroservice
```