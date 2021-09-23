const optionLoadScss = {
  loaderOptions: {
    sass: {
      additionalData: `@import "@/assets/scss/abstracts/index.scss"`,
    },
  },
};

module.exports = {
  devServer: {
    clientLogLevel: `info`,
    // css: optionLoadScss,
  },
};
