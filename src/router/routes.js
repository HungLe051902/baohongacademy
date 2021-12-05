import LandingPage from "@/views/LandingPage";
import Main from "@/views/main";
import About from "@/views/main/about";
import Register from "@/views/account/Register";
import Guideline from "@/views/Guideline";

export const routes = [
  {
    path: "/",
    name: "LandingPage",
    component: LandingPage,
  },
  {
    path: "/main",
    name: "Main",
    component: Main,
    children: [
      // Route cho trang giới thiệu
      {
        path: "about",
        name: "About",
        component: About,
      },
    ],
  },
  {
    path: "/register",
    name: "Register",
    component: Register,
  },
  {
    path: "/guideline",
    name: "Guideline",
    component: Guideline,
  },
];
