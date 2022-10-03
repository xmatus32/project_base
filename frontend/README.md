# frontend

## Recommended IDE Setup

[VSCode](https://code.visualstudio.com/) + [Volar](https://marketplace.visualstudio.com/items?itemName=Vue.volar) (and disable Vetur) + [TypeScript Vue Plugin (Volar)](https://marketplace.visualstudio.com/items?itemName=Vue.vscode-typescript-vue-plugin).

## Type Support for `.vue` Imports in TS

TypeScript cannot handle type information for `.vue` imports by default, so we replace the `tsc` CLI with `vue-tsc` for type checking. In editors, we need [TypeScript Vue Plugin (Volar)](https://marketplace.visualstudio.com/items?itemName=Vue.vscode-typescript-vue-plugin) to make the TypeScript language service aware of `.vue` types.


## Dev Project Setup
U need to clone this repository first. In VSCode open the repository and navigate to the `frontend` folder. Run this command to install all dependencies:
```sh
npm install
```

### Compile and Hot-Reload for Development
Run
```sh
npm run dev
```
and navigate to `http://localhost:3000/`.

### Type-Check, Compile and Minify for Production

```sh
npm run build
```
