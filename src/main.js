import { createApp } from "vue";
import App from "./App.vue";
import router from "./router";
// import ElementPlus from "element-plus";
// import "element-plus/dist/index.css";
import "bootstrap";
import "bootstrap/dist/css/bootstrap.min.css";

// Import css
import "@/assets/scss/main.scss";

const app = createApp(App);

app.use(router);
// app.use(ElementPlus);
app.mount("#app");
