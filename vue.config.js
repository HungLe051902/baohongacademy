const optionLoadScss = {
  loaderOptions: {
    sass: {
      additionalData: `@import "@/assets/scss/abstracts/index.scss";`,
      implementation: require("node-sass"),
    },
  },
};

module.exports = {
  css: optionLoadScss,
};
