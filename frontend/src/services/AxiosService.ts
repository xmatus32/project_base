import axios from "axios";
import json from "../../package.json";

const config = {
  baseURL: json.url,
  headers: {
    "Content-type": "application/json",
  },
  crossDomain: true,
};
const http = axios.create(config);
export default http;

//example usage in service:
// getHello() {
//   return http.get<string>("/hello");
// }
