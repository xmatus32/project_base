import { createRouter, createWebHistory } from "vue-router";
import HomeView from "../views/HomeView.vue";
import AboutView from "../views/AboutView.vue";
import NotFound from "../components/NotFound.vue";

const router = createRouter({
  history: createWebHistory(import.meta.env.BASE_URL),
  routes: [
    { path: "/", component: HomeView },
    { path: "/about", component: AboutView },
    { path: "/:pathMatch(.*)", component: NotFound },
  ],
  //routerLink requires Authentication
  // routes: [
  //   //{ path: "/home", component: "Home", meta: { requiresAuth: true } },
});

export default router;
