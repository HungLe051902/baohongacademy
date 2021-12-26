import axios from "axios";

export const HTTP = axios.create({
  baseURL: `https://localhost:44303/api`,
  // headers: {
  //   Authorization: "Bearer {token}",
  //   "Access-Control-Allow-Origin": "*",
  //   "Access-Control-Allow-Methods": "HEAD, GET, POST, PUT, PATCH, DELETE",
  //   "Access-Control-Allow-Headers": "Origin, Content-Type, X-Auth-Token",
  // },
  headers: {
    "Access-Control-Allow-Origin": "*",
  },
});
