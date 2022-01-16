import axios from "axios";
import { getToken } from "@/helpers/authenticationHelper.js";

export const HTTP = axios.create({
  baseURL: `https://localhost:44303/api`,
  timeout: 5000,
  headers: {
    "Access-Control-Allow-Origin": "*",
  },
});

axios.interceptors.request.use((request) => {
  request.headers.common.Authorization = `Bearer ${getToken()}`;
  return request;
});

axios.interceptors.response.use(
  function(response) {
    // Any status code that lie within the range of 2xx cause this function to trigger
    // Do something with response data
    return response;
  },
  function(error) {
    // Any status codes that falls outside the range of 2xx cause this function to trigger
    // Do something with response error
    return Promise.reject(error);
  }
);
