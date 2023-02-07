import { Environment } from '@abp/ng.core';

const baseUrl = 'http://localhost:4200';

export const environment = {
  production: false,
  application: {
    baseUrl,
    name: 'HaoTienEcommerce Admin',
    logoUrl: '',
  },
  oAuthConfig: {
    issuer: 'https://localhost:5000/',
    redirectUri: baseUrl,
    clientId: 'HaoTienEcommerce_Admin',
    dummyClientSecret:'1q2w3e*',
    responseType: 'code',
    scope: 'offline_access HaoTienEcommerce.Admin',
    requireHttps: true,
  },
  apis: {
    default: {
      url: 'https://localhost:5001',
      rootNamespace: 'HaoTienEcommerce.Admin',
    },
  },
} as Environment;
