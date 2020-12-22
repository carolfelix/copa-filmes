import axios from 'axios';

const api = axios.create({
    baseURL: 'http://localhost:58658/api',
  });


  export default api;