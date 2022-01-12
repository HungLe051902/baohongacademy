const TOKEN_KEY = "Token"

const saveToken = function(token) {
    localStorage.setItem(TOKEN_KEY, token);
};

const getToken = function() {
    localStorage.getItem(TOKEN_KEY);
};

export {saveToken, getToken}
