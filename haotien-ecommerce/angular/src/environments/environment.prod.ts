import { Environment } from '@abp/ng.core';

const baseUrl = 'http://localhost:4200';

export const environment = {
  production: true,
  application: {
    baseUrl,
    name: 'HaoTienEcommerce',
    logoUrl: '',
  },
  oAuthConfig: {
    issuer: 'https://localhost:44371/',
    redirectUri: baseUrl,
    clientId: 'HaoTienEcommerce_App',
    responseType: 'code',
    scope: 'offline_access HaoTienEcommerce',
    requireHttps: true
  },
  apis: {
    default: {
      url: 'https://localhost:44372',
      rootNamespace: 'HaoTienEcommerce',
    },
  },
} as Environment;
