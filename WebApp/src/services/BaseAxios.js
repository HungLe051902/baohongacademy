import axios from "axios";

export const HTTP = axios.create({
  baseURL: `https://localhost:44303/api`,
  //   headers: {
  //     Authorization: "Bearer {token}",
  //   },
});
