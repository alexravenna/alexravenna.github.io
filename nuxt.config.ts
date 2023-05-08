// https://nuxt.com/docs/api/configuration/nuxt-config
export default defineNuxtConfig({
  modules: ["@nuxt/content", "@nuxtjs/eslint-module"],
  typescript: { typeCheck: true, strict: true },
});
