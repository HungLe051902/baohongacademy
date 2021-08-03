

const optionLoadScss = {
    loaderOptions: {
        sass: {
            prependData: `@import "@/assets/scss/abstracts/index.scss"`
        }
    }
}

module.exports = {
    devServer: {
        css: optionLoadScss
    }
}