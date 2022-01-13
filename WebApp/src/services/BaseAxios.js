import axios from "axios";
import { getToken } from "@/helpers/authenticationHelper.js";

export const HTTP = axios.create({
  baseURL: `https://localhost:44303/api`,
  headers: {
    "Access-Control-Allow-Origin": "*",
  },
});

axios.interceptors.request.use((request) => {
  request.headers.common.Authorization = `Bearer ${getToken()}`;
  return request;
});
