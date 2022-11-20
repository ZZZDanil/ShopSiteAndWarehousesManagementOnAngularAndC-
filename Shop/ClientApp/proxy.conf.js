const { env } = require('process');

const target = env.ASPNETCORE_HTTPS_PORT ? `https://localhost:${env.ASPNETCORE_HTTPS_PORT}` :
  env.ASPNETCORE_URLS ? env.ASPNETCORE_URLS.split(';')[0] : 'http://localhost:41559';

const PROXY_CONFIG = [
  {
    context: [
      "/weatherforecast",
   ],
    target: target,
    secure: false,
    headers: {
      Connection: 'Keep-Alive'
    }
  },
  {
    context: [
      "/api",
    ],
    target: "https://localhost:7044",
    secure: false,
    headers: {
      Connection: 'Keep-Alive'
    }
  },
  {
    context: [
      "/api",
    ],
    target: "https://localhost:3000",
    secure: false,
    headers: {
      Connection: 'Keep-Alive'
    }
  },
  {
    context: [
      "/api",
    ],
    target: "https://localhost:4200",
    secure: false,
    headers: {
      Connection: 'Keep-Alive'
    }
  },
  {
    context: [
      "/api",
    ],
    target: "https://localhost:44462",
    secure: false,
    headers: {
      Connection: 'Keep-Alive'
    }
  },
  
]

module.exports = PROXY_CONFIG;
