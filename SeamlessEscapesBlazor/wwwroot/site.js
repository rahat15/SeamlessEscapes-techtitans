window.setFormName = function (formName) {
    const formElement = document.querySelector('form');
    if (formElement) {
        formElement.setAttribute('name', formName);
    }
};
